using MyLib;
using System;

namespace Variables2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            MyVariables.Swap(ref a, ref b);
            Console.WriteLine($"Число а = {a}, число b = {b}");
        }
    }
}
