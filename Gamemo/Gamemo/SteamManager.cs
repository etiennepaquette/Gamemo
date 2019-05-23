using Fluxter.SteamWebAPI;
using Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetOwnedGames;
using Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.GetAppList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public static class SteamManager
    {
        private static SteamIdentity User;
        private static List<App> AppList;

        public static void Init() {
            SteamWebAPI.SetGlobalKey("1E5E3956484C372C2D9AE6D58EFA4F69");
            var appListResponse = SteamWebAPI.General().ISteamApps().GetAppList().GetResponse();
            AppList = appListResponse.Data.Apps;
        }

        public static void SetSteamUser(long steamID) {
            User = SteamIdentity.FromSteamID(steamID);
        }

        public static List<Game> GetOwnedGames() {
            List<Game> gamesList = new List<Game>();

            var gameListResponse = SteamWebAPI.General().IPlayerService().GetOwnedGames(User).GetResponse();
            List<GetOwnedGamesResponseGame> gameList = gameListResponse.Data.Games;
            foreach (GetOwnedGamesResponseGame g in gameList) {
                string gameName = AppList.Find(item => item.AppID == g.AppID).Name;
                if (gameName != null) {
                    gamesList.Add(new Game(g.AppID, gameName));
                }
            }

            return gamesList;
        }
    }
}
