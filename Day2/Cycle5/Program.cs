using MyLib;
using System;

namespace Cycle5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Cycle.SumOfDivisibleNum(7, a, b));
            }
        }
    }
}
