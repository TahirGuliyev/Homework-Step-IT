using System;
namespace HomeWorks
{
    class Fraction {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                Denominator = denominator;
                Numerator = numerator;
            }
            else {
                Console.WriteLine("Sifira bolmek mumkun deyil");
            }
        }
        public void Print() {
            Console.WriteLine(Numerator+"/"+Denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b) {
            Fraction fr = new Fraction(1,1);
            fr.Numerator = a.Numerator*b.Denominator + b.Numerator*a.Denominator;
            fr.Denominator = a.Denominator * b.Denominator;
            return fr;
        }
        public static Fraction operator +(Fraction a, int b)
        {
            a.Numerator = a.Numerator * b;
            return a;
        }
        public static Fraction operator +(Fraction a, double b)
        {
            a.Numerator = a.Numerator * b;
            return a;
        }
        public static Fraction operator +(int b, Fraction a)
        {
            a.Numerator = a.Numerator * b;
            return a;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            fr.Denominator = a.Denominator * b.Denominator;
            return fr;
        }
        public static Fraction operator -(Fraction a, int b)
        {
            a.Numerator = a.Numerator * (-b);
            return a;
        }
        public static Fraction operator -(int b, Fraction a)
        {
            a.Numerator = a.Numerator * (-b);
            return a;
        }
        public static Fraction operator*(Fraction a, Fraction b)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = a.Numerator * b.Numerator;
            fr.Denominator = a.Denominator * b.Denominator;
            return fr;
        }
        public static Fraction operator *(Fraction a, int b)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = a.Numerator * b;
            fr.Denominator = a.Denominator * b;
            return fr;
        }
        public static Fraction operator *(int b, Fraction a)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = b * a.Numerator ;
            fr.Denominator = b * a.Denominator;
            return fr;
        }
        public static Fraction operator/(Fraction a, Fraction b)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = a.Numerator * b.Denominator;
            fr.Denominator = a.Denominator * b.Numerator;
            return fr;
        }
        public static Fraction operator /(Fraction a, int b)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = a.Numerator / b;
            fr.Denominator = a.Denominator / b;
            return fr;
        }
        public static Fraction operator /(int b, Fraction a)
        {
            Fraction fr = new Fraction(1, 1);
            fr.Numerator = b / a.Numerator;
            fr.Denominator = b / a.Denominator;
            return fr;
        }
        public static bool operator ==(Fraction a, Fraction b) {
            if (a.Numerator == b.Numerator && a.Denominator == b.Denominator) return true;
            else return false;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            if (a.Numerator == b.Numerator && a.Denominator == b.Denominator) return false;
            else return true;
        }
        public static bool operator>(Fraction a, Fraction b)
        {
            if (a.Numerator/a.Denominator>b.Numerator/b.Denominator) return false;
            else return true;
        }
        public static bool operator<(Fraction a, Fraction b)
        {
            if (a.Numerator / a.Denominator < b.Numerator / b.Denominator) return false;
            else return true;
        }
        public static bool operator true(Fraction a)
        {
            if (a.Numerator>a.Denominator) return true;
            else return false;
        }
        public static bool operator false(Fraction a)
        {
            if (a.Numerator > a.Denominator) return true;
            else return false;
        }
    }
    class Homework
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            if (f) { Console.WriteLine("f kesri duz kesrdir"); }
            else { Console.WriteLine("f kesri duz olmayan kesrdir");}

            if (f3) { Console.WriteLine("f3 kesri duz kesrdir"); }
            else { Console.WriteLine("f3 kesri duz olmayan kesrdir");}
            Console.ReadKey();
        }
    }
}
