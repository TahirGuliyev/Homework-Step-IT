using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Tank
    {
        protected string Name { get; set; }
        protected int Ammunition { get; set; }
        protected int Armor { get; set; }
        protected int Maneuverability { get; set; }
        protected bool LiveStatus { get; set; }
        protected Tank()
        {
            Random random = new Random();
            Ammunition = random.Next(0, 100);
            Armor = random.Next(0, 100);
            Maneuverability = random.Next(0, 100);
            LiveStatus = true;
        }
        public static Tank operator *(Tank first, Tank second)
        {
            int tank_first = 0;
            int tank_second = 0;

            if (first.LiveStatus == false || second.LiveStatus == false)
                throw new MyException();

            if (first.Ammunition > second.Ammunition)
                tank_first++;
            else if (first.Ammunition < second.Ammunition)
                tank_second++;

            if (first.Armor > second.Armor)
                tank_first++;
            else if (first.Armor < second.Armor)
                tank_second++;

            if (first.Maneuverability > second.Maneuverability)
                tank_first++;
            else if (first.Maneuverability < second.Maneuverability)
                tank_second++;

            if (tank_first > tank_second)
            {
                second.LiveStatus = false;
                return first;
            }
            else if (tank_first < tank_second)
            {
                first.LiveStatus = false;
                return second;
            }

            return null;

        }
    }
}
