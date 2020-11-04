using MyLib;
using System;

namespace Cycle1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число А");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень B");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Число {a}, возведенное в степень {b} равно ");
                Console.WriteLine(Cycle.Degree(a, b));
            }
        }
    }
}
