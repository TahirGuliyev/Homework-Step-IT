using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Parallelogram : Figure
    {
        public double UzunTeref { get; set; }
        public double QisaTeref { get; set; }
        public double Hundurluk { get; set; }

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
