using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Triangle : GeometricalFigure, SimpleNGon
    {
        public double Teref1 { get; set; }
        public double Teref2 { get; set; }
        public double Teref3 { get; set; }

        public double Height { get; set; }

        public double Base { get; set; }

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 3;

        public double SidesLenght => Teref1;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

        public Triangle() : this(0,0,0) { }

        //beraberterefli ucbucaq
        public Triangle(double teref1)
        {
            Teref1 = teref1;
            Teref2 = teref1;
            Teref3 = teref1;
        }

        //beraberyanli ucbucaq
        public Triangle(double teref, double oturacaq)
        {
            Teref1 = teref;
            Teref2 = teref;
            Teref3 = oturacaq;
        }
        //Ferqli terefli ucbucaq
        public Triangle(double teref1, double teref2, double teref3) {
            Teref1 = teref1;
            Teref2 = teref2;
            Teref3 = teref3;
        }

        public override double Area()
        {
            double p = Perimeter();
            double area = Math.Sqrt(p * (p - Teref1) * (p - Teref2) * (p - Teref3));
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = (Teref1 + Teref2 + Teref3) / 2;
            return perimeter;
        }
    }
}
