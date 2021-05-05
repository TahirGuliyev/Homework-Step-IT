using HomeWorks.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Rhombus : GeometricalFigure, SimpleNGon
    {
        public double Teref { get; set; }
        public double Hundurluk { get; set; }

        public double Height => throw new NotImplementedException();

        public double Base => throw new NotImplementedException();

        public double AngleBetweenBaseAndAdjacentSide => throw new NotImplementedException();

        public double NumberOfSides => throw new NotImplementedException();

        public double SidesLenght => throw new NotImplementedException();

        double SimpleNGon.Area => throw new NotImplementedException();

        public double Perimetr => throw new NotImplementedException();

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
