using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

        repit:

            int d = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            if (a < 0)
            {
                while (true)
                {
                    if (d == 0)
                    {
                        Console.WriteLine("попытка деления на нуль");
                        Console.WriteLine("повтори ещё раз");
                        goto repit;
                    }
                    else
                    {
                        result = (a + b + c) / d;
                        break;
                    }
                }

            }
            else if (a == 0)
            {
                result = 100 + b * c - d;
            }
            else if (a > 0)
            {
                result = a * b * c * d;
            }
            else
            {
                result = a * b;
            }

            Console.WriteLine(result);

        }
    }
}