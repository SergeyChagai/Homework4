using MyLib;
using System;

namespace Cycle6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер числа из последовательности Фибоначчи, которое хотите узнать: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Cycle.NumOfFibonacci(n));
            }
        }
    }
}
