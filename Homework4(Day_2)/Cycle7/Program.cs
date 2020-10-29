using MyLib;
using System;

namespace Cycle7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два положительных целых числа:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Наибольший общий делитель равен {Cycle.GreatestCommonFactor(a, b)}");
            }
        }
    }
}
