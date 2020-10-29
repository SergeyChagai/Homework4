using MyLib;
using System;

namespace Branching2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyBranching.Condition1(a, b));
        }
    }
}
