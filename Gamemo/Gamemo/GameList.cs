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
            Game g = GetGame(name);
            if (g != null) {
                games.Remove(GetGame(name));
            }
        }

        public void UpdateGameMemo(string name, string newMemo) {
            Game g = GetGame(name);
            if (g != null) {
                games.Remove(g);
                games.Add(new Game(name, newMemo));
            }
        }

        public string GetGameMemo(string name) {
            Game g = GetGame(name);
            if (g != null) {
                return g.Memo;
            }
            return null;
        }

        private Game GetGame(string name) {
            foreach (Game g in games) {
                if (g.Name == name)
                    return g;
            }
            return null;
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
