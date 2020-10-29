using MyLib;
using System;

namespace Cycle12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
               

                switch (Cycle.SameDigits(a, b))
                {
                    case false:
                        Console.WriteLine("В этих числах нет одинаковых цифр");
                        break;
                    case true:
                        Console.WriteLine("В этих числах есть одинаковые цифры");
                        break;
                }
            }
        }
    }
}
