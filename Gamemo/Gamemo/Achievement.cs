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
        public string IconGray { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Memo { get; set; }
        public float GlobalPercentage { get; set; }
        public bool Achieved { get; set; }

        public Achievement() { }

        public Achievement(string icon, string iconGray, string name, string description, float globalPerc, bool achieved) {
            Icon = icon;
            IconGray = iconGray;
            Name = name;
            Description = description;
            GlobalPercentage = globalPerc;
            Achieved = achieved;
        }
    }
}
