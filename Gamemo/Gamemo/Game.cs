using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public class Game
    {
        public int AppID { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }

        public Game() { }

        public Game(string name) {
            Name = name;
        }

        public Game(string name, string memo) {
            Name = name;
            Memo = memo;
        }

        public Game(int appID, string name) {
            AppID = appID;
            Name = name;
        }
    }
}
