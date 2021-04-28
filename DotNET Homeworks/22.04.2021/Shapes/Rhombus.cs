using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Rhombus : Figure
    {
        public double Teref { get; set; }
        public double Hundurluk { get; set; }

        public Rhombus() : this(0,0) {}
        public Rhombus(double teref, double hundurluk)
        {
            Teref = teref;
            Hundurluk = hundurluk;
        }


        public override double Area()
        {
            double area = Hundurluk * Teref;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = Teref * 4;
            return perimeter;
        }
    }
}
