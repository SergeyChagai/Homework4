using MyLib;
using System;

namespace Cycle4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        Console.WriteLine("Ошибка. введите ненулевое число");
                        continue;
                    case 1:
                        Console.WriteLine("Ошибка. введите число больше 1");
                        continue;
                }
                

                Console.WriteLine("Наибольший делитель числа " + a + " равен " + Cycle.BiggerDividerOf(a));
            }
        }
    }
}
