using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Gamemo
{
    public class GameList
    {
        List<Game> games = new List<Game>();

        public void AddGame(string name) {
            games.Add(new Game(name));
        }

        public void RemoveGame(string name) {
            games.RemoveAll(x => x.Name == name);
        }

        public void UpdateGameMemo(string name, string newMemo) {
            games.Find(x => x.Name == name).Memo = newMemo;
        }

        public string GetGameMemo(string name) {
            return games.Find(x => x.Name == name).Memo;
        }

        public List<string> GetAllGameNames() {
            List<string> names = new List<string>();
            foreach (Game g in games) {
                names.Add(g.Name);
            }
            return names;
        }

        public void Save(string fileName) {
            File.WriteAllText(fileName, JsonConvert.SerializeObject(games, Formatting.Indented));
        }

        public void Load(string fileName) {
            games = JsonConvert.DeserializeObject<List<Game>>(File.ReadAllText(fileName));
        }
    }
}
