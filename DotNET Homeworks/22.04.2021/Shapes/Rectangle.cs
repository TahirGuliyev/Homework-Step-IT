using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Rectangle : Figure
    {
        public double Teref1 { get; set; }
        public double Teref2 { get; set; }
        public Rectangle() : this(0,0) {}
        public Rectangle(double teref1, double teref2)
        {
            Teref1 = teref1;
            Teref2 = teref2;
        }

        public override double Area()
        {
            double area = Teref1 * Teref2;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = (Teref1 + Teref2) * 2;
            return perimeter;
        }
    }
}
