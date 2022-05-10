using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public class Game
    {
        public bool IsSteamGame { get; set; }
        public int AppID { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public List<Achievement> achievements = new List<Achievement>();

        public Game() { }

        public Game(string name) {
            Name = name;
            IsSteamGame = false;
        }

        public Game(int appID, string name) {
            AppID = appID;
            Name = name;
            IsSteamGame = true;
        }
    }
}
