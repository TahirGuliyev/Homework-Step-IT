using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Ellipse : Figure
    {
        public double QisaRadius { get; set; }
        public double UzunRadius { get; set; }
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
