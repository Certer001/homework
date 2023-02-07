using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1.1, 1.3, 2.4, 2.6, 2.9 };

            double maxNumber = 0;
            double minNumber = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                }

                if (arr[i] < minNumber)
                {
                    minNumber = arr[i];
                }
            }

            Console.WriteLine("Максимальное число: " + maxNumber);
            Console.WriteLine("Минимальное число: " + minNumber);

            Console.ReadLine();
        }
    }
}