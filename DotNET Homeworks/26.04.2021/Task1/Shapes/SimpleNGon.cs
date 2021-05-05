using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks.Shapes
{
    interface SimpleNGon
    {
        public double Height { get; }
        public double Base { get; }  
        public double AngleBetweenBaseAndAdjacentSide { get; }
        public double NumberOfSides { get; }
        public double SidesLenght { get; }
        public double Area { get; }
        public double Perimetr { get; }
    }
}
