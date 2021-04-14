using System;

namespace HomeWorks
{
    class Number
    {
        /*
        Given an integer N (> 0), find the number obtained when reading 
        this number from right to left. For example, if you type 345, 
        the program should display 543.
        */
        static void Main(string[] args)
        {
            int number;
            int reverseNumber = 0;
            Console.WriteLine("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                reverseNumber = reverseNumber * 10 + number % 10;
                number = number / 10;
            }

            Console.WriteLine("Reverse number is : " + reverseNumber);
            Console.ReadKey();
        }
    }
}