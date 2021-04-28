using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Square : Figure
    {
        public double Teref { get; set; }
        public Square() : this(0){}
        public Square(double teref)
        {
            Teref = teref;
        }
        public override double Area() {
            double area = Teref * Teref;
            return area;
        }
        public override double Perimeter() {
            double perimeter = Teref * 4;
            return perimeter;
        }
    }
}
