using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Trapezium : GeometricalFigure, SimpleNGon
    {
        public double Oturacaq1 { get; set; }
        public double Oturacaq2 { get; set; }
        public double Teref1 { get; set; }
        public double Teref2 { get; set; }
        public double Height { get; set; }

        public double Base { get; set; }

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 4;

        public double SidesLenght => Teref1;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

        public Trapezium() : this(0,0,0,0,0)  {}
        public Trapezium(double oturacaq1, double oturacaq2, double teref1, double teref2, double hundurluk)
        {
            Oturacaq1 = oturacaq1;
            Oturacaq2 = oturacaq2;
            Teref1 = teref1;
            Teref1 = teref2;
            Height = hundurluk;
        }
        public override double Area()
        {
            double area = (Oturacaq1 + Oturacaq2) * Height / 2;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = Oturacaq1 + Oturacaq2 + Teref1 + Teref1;
            return perimeter;
        }
    }
}
