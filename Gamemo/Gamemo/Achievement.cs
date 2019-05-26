using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamemo
{
    public class Achievement
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string APIName { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }

        public Achievement() { }

        public Achievement(string icon, string name, string apiName, string description) {
            Icon = icon;
            Name = name;
            APIName = apiName;
            Description = description;
        }
    }
}
