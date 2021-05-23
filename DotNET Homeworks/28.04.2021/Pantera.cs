using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Pantera : Tank
    {
        public int Maneuverability() { return base.Maneuverability; }
        public int Ammunition() { return base.Ammunition; }
        public string Name() { return "Pantera"; }
        public int Armor() { return base.Armor; }
    }
}
