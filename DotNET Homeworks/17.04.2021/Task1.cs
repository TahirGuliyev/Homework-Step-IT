using System;

namespace HomeWorks
{
    class Homework
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int[] newArr = new int[arr.Length];
            int it = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i]+" ");
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[it] = arr[i];
                    it++;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == 0)
                {
                    newArr[it] = -1;
                    it++;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write(newArr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
