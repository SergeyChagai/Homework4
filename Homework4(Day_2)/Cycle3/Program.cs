using MyLib;
using System;

namespace Cycle3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Существует {Cycle.AmountOfNumSquareLessThan(a)} положительных целых чисел, квадрат которых меньше {a}");
            }
        }
    }
}
