using Fluxter.SteamWebAPI;
using Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetOwnedGames;
using Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.GetAppList;
using Fluxter.SteamWebAPI.Interfaces.General.ISteamUserStats.GetPlayerAchievements;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gamemo
{
    public class PlayerAchievements
    {
        public int achieved { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class GameAchievements
    {
        public string displayname { get; set; }
        public string icon { get; set; }
        public string icongray { get; set; }
    }

    public static class SteamManager
    {
        private const string GlobalKey = "1E5E3956484C372C2D9AE6D58EFA4F69";
        private static WebClient WC;
        private static SteamIdentity User;
        private static long SteamID;
        private static List<App> AppList;
        public static bool IsSteamProfile = true;

        public static void Init(long steamID) {
            WC = new WebClient() { Encoding = Encoding.UTF8 };
            if (steamID == 0) {
                IsSteamProfile = false;
                return;
            }

            SteamWebAPI.SetGlobalKey(GlobalKey);
            SetSteamUser(steamID);

            var json = WC.DownloadString($"https://api.steampowered.com/ISteamApps/GetAppList/v2?key={GlobalKey}&language=en-us&format=json");
            var parsedObject = JObject.Parse(json);
            AppList = JsonConvert.DeserializeObject<List<App>>(parsedObject["applist"]["apps"].ToString());
        }

        public static void SetSteamUser(long steamID) {
            SteamID = steamID;
            User = SteamIdentity.FromSteamID(steamID);
        }

        public static List<Game> GetOwnedGames() {
            List<Game> gamesList = new List<Game>();

            var gameListResponse = SteamWebAPI.General().IPlayerService().GetOwnedGames(User).GetResponse();
            List<GetOwnedGamesResponseGame> gameList = gameListResponse.Data.Games;
            foreach (GetOwnedGamesResponseGame g in gameList) {
                var game = AppList.Find(x => x.AppID == g.AppID);
                if (game != null) {
                    gamesList.Add(new Game(g.AppID, game.Name));
                }
            }

            return gamesList;
        }

        public static Dictionary<string, float> GetGlobalAchievePercentagesByHTML(int appID) {
            // https://api.steampowered.com/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v2/?gameid=
            Dictionary<string, float> globalAchievePerc = new Dictionary<string, float>();
            string url = @"https://steamcommunity.com/stats/"+ appID +"/achievements/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class,'achieveRow')]");

            foreach (var achieve in nodes) {
                string percentText = achieve.Descendants("div").Where(x => x.HasClass("achievePercent")).First().InnerHtml;
                float percent = float.Parse(percentText.Remove(percentText.Length - 1));
                string name = achieve.Descendants("h3").First().InnerHtml;
                globalAchievePerc[name] = percent;
            }

            return globalAchievePerc;
        }

        public static List<Achievement> GetGameAchievements(int appID) {

            Dictionary<string, float> globalAchievePerc = GetGlobalAchievePercentagesByHTML(appID);
            var json = WC.DownloadString($"https://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v1/?key={GlobalKey}&steamid={SteamID}&appid={appID}&l=en-us");
            var parsedObject = JObject.Parse(json);
            var achievements = JsonConvert.DeserializeObject<List<PlayerAchievements>>(parsedObject["playerstats"]["achievements"].ToString());
            
            var jsonGameAchievements = WC.DownloadString($"http://api.steampowered.com/ISteamUserStats/GetSchemaForGame/v0002/?key={GlobalKey}&appid={appID}&l=english&format=json");
            var parsedObjectGameAchievements = JObject.Parse(jsonGameAchievements);
            var gameAchievements = JsonConvert.DeserializeObject<List<GameAchievements>>(parsedObjectGameAchievements["game"]["availableGameStats"]["achievements"].ToString());


            List<Achievement> achievementList = new List<Achievement>();
            foreach (var ach in achievements) {
                //if (ach.achieved == 0) {
                    var gameAchievement = gameAchievements.Find(x => x.displayname == ach.name);
                    achievementList.Add(new Achievement(gameAchievement.icon, gameAchievement.icongray, ach.name, ach.description, globalAchievePerc[ach.name], ach.achieved == 1));
                //}
            }
            return achievementList;//.OrderByDescending(x => x.GlobalPercentage).ToList();
        }
        /*
        private static List<Achievement> GetAchieveByHTML(int appID, Dictionary<string, float> globalAchievePerc) {
            List<Achievement> achievementList = new List<Achievement>();
            var html = @"https://steamcommunity.com/profiles/" + SteamID + "/stats/" + appID;
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var nodes = htmlDoc.DocumentNode.SelectNodes("//html[1]/body[1]/div[1]/div[7]/div[2]/div[1]/div[2]/div[1]/div[4]");

            if (nodes != null && nodes.First().Id == "personalAchieve") {
                foreach (var achieve in nodes.First().Elements("div")) {
                    if (achieve.Descendants("div").Where(x => x.HasClass("achieveUnlockTime")).Count() == 1) {
                        continue;
                    }
                    if (achieve.Descendants("img").Count() != 0) {
                        var img = achieve.Descendants("img").First().Attributes["src"].Value;
                        var name = achieve.Descendants("h3").First().InnerHtml;
                        var desc = achieve.Descendants("h5").First().InnerHtml;
                        achievementList.Add(new Achievement(img, name, desc, globalAchievePerc[name]));
                    }
                }
            }

            return achievementList;
        }
        */
        /*
        private static List<Achievement> GetAchieveByXML(int appID, Dictionary<string, float> globalAchievePerc)
        {
            List<Achievement> achievementList = new List<Achievement>();
            String URLString = "https://steamcommunity.com/profiles/" + SteamID + "/stats/" + appID + "/achievements/?xml=1";
            XmlTextReader reader = new XmlTextReader(URLString);
            bool readingAchievement = false;
            Achievement achievement = new Achievement();

            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element: // The node is an element.
                        if (readingAchievement) {
                            if (reader.Name == "iconClosed") {
                                achievement.Icon = reader.ReadString();
                            } else if (reader.Name == "name") {
                                achievement.Name = reader.ReadString();
                            } else if (reader.Name == "description") {
                                achievement.Description = reader.ReadString();
                            }
                        } else if (reader.Name == "achievement") {
                            while (reader.MoveToNextAttribute()) { // Read the attributes.
                                if (reader.Name == "closed" && reader.Value == "0") {
                                    readingAchievement = true;
                                    achievement = new Achievement();
                                }
                            }
                        }
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        if (reader.Name == "achievement" && readingAchievement) {
                            readingAchievement = false;
                            achievement.GlobalPercentage = globalAchievePerc[achievement.Name];
                            achievementList.Add(achievement);
                        }
                        break;
                }
            }

            return achievementList;
        }
        */
    }
}
