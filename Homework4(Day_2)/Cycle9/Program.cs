using MyLib;
using System;

namespace Cycle9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Количество нечетных цифр в этом числе равно " + Cycle.ImpairDigits(a));
            }
        }
    }
}
