using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Parallelogram : GeometricalFigure, SimpleNGon
    {
        public double UzunTeref { get; set; }
        public double QisaTeref { get; set; }
        public double Height { get; set; }

        public double Base { get; set; }

        public double AngleBetweenBaseAndAdjacentSide { get; set; }

        public double NumberOfSides => 4;

        public double SidesLenght => UzunTeref;

        double SimpleNGon.Area => Area();

        public double Perimetr => Perimeter();

        public Parallelogram() : this(0,0,0) {}
        public Parallelogram(double uzunTeref, double qisaTeref, double hundurluk)
        {
            UzunTeref = uzunTeref;
            QisaTeref = qisaTeref;
            Hundurluk = hundurluk;
        }
        public override double Area()
        {
            double area = Hundurluk * UzunTeref;
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = (UzunTeref+QisaTeref) * 2;
            return perimeter;
        }
    }
}
