using System;
using MyLib;

namespace Branching1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точки");
            Console.Write("x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyBranching.Quarters(x, y));
        }
    }
}
