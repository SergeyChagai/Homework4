using MyLib;
using System;

namespace Branching4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || a == 1 || b == 0 || c == 0)
            {
                Console.WriteLine("Это не полное квадратное уравнение, я не такая программа");
                return;
            }
            if (b * b - 4 * a * c < 0)
            {
                Console.WriteLine("Корней нет");
                return;
            }

            Console.WriteLine((-b + MyBranching.Sqrt(b * b - 4 * a * c)) / (2 * a));
            Console.WriteLine((-b - MyBranching.Sqrt(b * b - 4 * a * c)) / (2 * a));
            return;

        }
    }
}
