using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    class Profile
    {
        public string Name { get; set; }
        public long SteamID { get; set; }

        public Profile(string name, long steamID = 0) {
            Name = name;
            SteamID = steamID;
        }
    }
}
