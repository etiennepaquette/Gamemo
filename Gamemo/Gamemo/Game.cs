using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public class Game
    {
        public bool SteamGame { get; set; }
        public int AppID { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }

        public Game() { }

        public Game(string name) {
            Name = name;
            SteamGame = false;
        }

        public Game(int appID, string name) {
            AppID = appID;
            Name = name;
            SteamGame = true;
        }
    }
}
