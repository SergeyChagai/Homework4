using MyLib;
using System;

namespace Cycle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cycle.AmountOfNumWhoDivide(a, 1000));
        }
    }
}
