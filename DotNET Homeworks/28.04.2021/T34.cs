using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class T34 : Tank
    {
        public int Maneuverability() { return base.Maneuverability; }
        public int Ammunition() { return base.Ammunition; }
        public string Name() { return "T-34"; }
        public int Armor() { return base.Armor; }
    }
}
