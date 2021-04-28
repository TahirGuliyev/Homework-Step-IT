using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle() : this(0)  {}
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = Radius * 2 * Math.PI;
            return perimeter;
        }
    }
}
