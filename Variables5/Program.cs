using System;
using Variables;

namespace Variables5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки А");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyEquals.StraightLineEquation(x1, y1, x2, y2));
        }
    }
}
