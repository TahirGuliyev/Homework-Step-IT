using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Circle : GeometricalFigure, SimpleNGon
    {
        public double Radius { get; set; }

        public double Height => 0;

        public double Base => 0;

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 0;

        public double SidesLenght => 0;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

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
