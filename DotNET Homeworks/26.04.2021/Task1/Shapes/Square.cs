using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Square : GeometricalFigure, SimpleNGon
    {
        public double Teref { get; set; }

        public double Height => Teref;

        public double Base { get; set; }

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 4;

        public double SidesLenght => Teref;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

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
