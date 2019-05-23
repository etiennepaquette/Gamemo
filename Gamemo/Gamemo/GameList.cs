using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Gamemo
{
    public static class GameList
    {
        public static List<Game> games = new List<Game>();

        public static void AddGame(string name) {
            games.Add(new Game(name));
        }

        public static void RemoveGame(string name) {
            games.RemoveAll(x => x.Name == name);
        }

        public static void UpdateGameMemo(string name, string newMemo) {
            games.Find(x => x.Name == name).Memo = newMemo;
        }

        public static string GetGameMemo(string name) {
            return games.Find(x => x.Name == name).Memo;
        }

        public static List<string> GetAllGameNames() {
            List<string> names = new List<string>();
            foreach (Game g in games) {
                names.Add(g.Name);
            }
            return names;
        }

        public static void Save(string fileName) {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(games, Formatting.Indented));
        }

        public static void Load(string fileName) {
            games = JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(fileName));
        }
    }
}
