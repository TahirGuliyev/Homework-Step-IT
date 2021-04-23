using System;

namespace HomeWorks
{
    class Homework
    {
        /*
         Write a program that offers the user to enter a number,
        and then counts how many times this number occurs in
        the array
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = random.Next(10, 15);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            int numb = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numb == arr[i]) count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
