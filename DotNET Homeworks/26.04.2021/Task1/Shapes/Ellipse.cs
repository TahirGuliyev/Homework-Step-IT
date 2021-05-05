using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Ellipse : GeometricalFigure, SimpleNGon
    {
        public double QisaRadius { get; set; }
        public double UzunRadius { get; set; }

        public double Height => 0;

        public double Base => 0;

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 0;

        public double SidesLenght => 0;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

        public Ellipse() : this(0,0) {}
        public Ellipse(double qisaRadius, double uzunRadius)
        {
            QisaRadius = qisaRadius;
            UzunRadius = uzunRadius;
        }
        public override double Area()
        {
            double area = Math.PI * QisaRadius * UzunRadius;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * Math.Sqrt(1 / 2 * (QisaRadius * QisaRadius + UzunRadius * UzunRadius));
            return perimeter;
        }
    }
}
