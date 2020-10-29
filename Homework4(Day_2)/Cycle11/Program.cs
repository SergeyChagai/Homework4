using MyLib;
using System;

namespace Cycle11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое положительное число");
                int n = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine($"Количество чисел от 1 до {n}, сумма четных цифр которых больше суммы нечетных цифр равно {Cycle.PairImpair(1, n)}");
            }
        }
    }
}
