using System;

namespace HomeWorks
{
    class Homework
    {
        /*
         Swap the columns of the two-dimensional array of M by N.
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            int size = random.Next(3, 7);
            int[,] arr = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = random.Next(0, 10);
                    Console.Write(arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int numb1 = Convert.ToInt32(Console.ReadLine());
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int[,] newArr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == numb1)
                    {
                        newArr[i, j] = arr[i, numb2];
                    }
                    else if (j == numb2)
                    {
                        newArr[i, j] = arr[i, numb1];
                    }
                    else {
                        newArr[i, j] = arr[i, j];
                    }
                    Console.Write(newArr[i, j] + " ");
                }                
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
