using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Gamemo
{
    public static class GameList
    {
        private static List<Game> games = new List<Game>();

        public static void AddGame(string name) {
            games.Add(new Game(name));
        }

        public static void AddSteamGame(int appID, string name)
        {
            Game game = new Game(appID, name);
            game.achievements = SteamManager.GetGameAchievements(appID);
            games.Add(game);
        }

        public static void RemoveGame(string name) {
            games.RemoveAll(x => x.Name == name);
        }

        public static void UpdateGameMemo(string name, string newMemo) {
            Game game = games.Find(x => x.Name == name);
            if (game != null) {
                game.Memo = newMemo;
            }
        }

        public static void UpdateGameAchiev(string gameName, List<Achievement> achievs) {
            Game game = games.Find(x => x.Name == gameName);
            if (game != null) {
                game.achievements = achievs;
            }
        }

        public static string GetGameMemo(string name) {
            Game game = games.Find(x => x.Name == name);
            if (game != null) {
                return game.Memo;
            }
            return null;
        }

        public static List<Achievement> GetAchievements(string gameName) {
            Game game = games.Find(x => x.Name == gameName);
            if (game != null) {
                return game.achievements;
            }
            return null;
        }

        public static List<string> GetAllGameNames() {
            List<string> names = new List<string>();
            foreach (Game g in games) {
                names.Add(g.Name);
            }
            return names;
        }

        public static bool IsSteamGame(string gameName) {
            Game game = games.Find(x => x.Name == gameName);
            if (game != null) {
                return game.IsSteamGame;
            }
            return false;
        }

        public static void Save(string profileName) {
            if (games.Count != 0) {
                string fileName = Application.StartupPath + "/" + profileName + ".json";
                File.WriteAllText(fileName, JsonConvert.SerializeObject(games, Formatting.Indented));
            }
        }

        public static void Load(string profileName){
            string fileName = Application.StartupPath + "/" + profileName + ".json";
            if (File.Exists(fileName)) {
                games = JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(fileName));
            }
        }
    }
}
