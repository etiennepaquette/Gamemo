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
        public static List<Game> games = new List<Game>();
        private static readonly string FileName = String.Format(@"{0}\GameList.json", Application.StartupPath);

        public static void AddGame(string name) {
            games.Add(new Game(name));
        }

        public static void AddGame(int appID, string name)
        {
            games.Add(new Game(appID, name));
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

        public static string GetGameMemo(string name) {
            Game game = games.Find(x => x.Name == name);
            if (game != null) {
                return game.Memo;
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

        public static void Save() {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(games, Formatting.Indented));
        }

        public static void Load(){
            if (File.Exists(FileName)) {
                games = JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(FileName));
            }
        }
    }
}
