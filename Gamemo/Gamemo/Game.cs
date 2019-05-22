using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public class Game
    {
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
    }
}
