using System;

namespace HomeWorks
{
    class Duzbucaqli
    {
        /*
        A, B ve C int tipli musbet ededler klaviaturadan daxil olunur. 
        AxB dordbucaqlinin daxilinde terefleri C-ye beraber olan kvadratlar yerleshdirilib. 
        Kvadratlar ust uste dushmur. AxB dordbucaqlinin daxilinde nece eded kvadrat var?
        */
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            int kvadratSayi;

            Console.WriteLine("Duzbucaqlinin enini daxil edin:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Duzbucaqlinin uzununu daxil edin:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kvadratin terefini daxil edin:");
            C = Convert.ToDouble(Console.ReadLine());
            kvadratSayi = (int)(A / C) * (int)(B / C);
            Console.WriteLine("Daxil etdiyiniz duzbucaqli daxiline " + kvadratSayi + " eded kvadrat yerlesir.");

            Console.ReadKey();
        }
    }
}
