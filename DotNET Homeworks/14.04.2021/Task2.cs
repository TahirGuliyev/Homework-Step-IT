using System;

namespace HomeWorks
{
    class LuckyTicket
    {
        /*
        Enter the number of a tram ticket (6-digit number) from the keyboard, 
        and then check whether this ticket is «lucky» (the ticket is considered lucky, 
        if the sum of the first three digits equals the sum of the last three).
        */
        static void Main(string[] args)
        {
            int ticketNumber;
            int firstThree;
            double lastThree;

            Console.WriteLine("Enter the number of a tram ticket (6-digit number)");
            ticketNumber = Convert.ToInt32(Console.ReadLine());

            firstThree = ticketNumber / 100000 + ticketNumber / 10000 % 10 + ticketNumber / 1000 % 10;
            lastThree = ticketNumber / 100 % 10 + ticketNumber / 10 % 10 + ticketNumber % 10;

            if (firstThree == lastThree)
            {
                Console.WriteLine("This ticket is «lucky»");
            }
            else { Console.WriteLine("This ticket is not «lucky»"); }

            Console.ReadKey();
        }
    }
}