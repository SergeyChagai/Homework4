using System;
using Variables;

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

            MyEquals.Swap(ref a, ref b);
            Console.WriteLine($"Число а = {a}, число b = {b}");
        }
    }
}
