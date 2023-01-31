using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (arr[i] < 10)
                {
                    arr[i] = 0;
                }

                arr[i] *= arr[i];
            }

            Console.WriteLine("\nПреобразованный массив:\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("\n");

        }
    }
}