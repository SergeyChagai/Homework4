using MyLib;
using System;

namespace Variables4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение типа \"a * x + b = c\"\nВведите коэффициенты a, b и c");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Коэффициент \"a\" не должен юыть равен нулю");
            else
                Console.WriteLine($"X равен {MyVariables.EqualsType2(a, b, c)}");
        }
    }
}
