using System;

namespace HomeWorks
{
    class CountSpaces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonu noqte ile biten bir cumle ve ya metn daxil edin.");
            char ch;
            int spaces = 0;
            do
            {
                ch = (char)Console.Read();
                if (ch == ' ')
                {
                    spaces++;
                }
            } while (ch != '.');

            Console.WriteLine("Daxil etdiyiniz metnde bosluqlarin sayi = " + spaces);
            Console.ReadKey();
        }
    }
}
