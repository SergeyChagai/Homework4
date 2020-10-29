using MyLib;
using System;

namespace Cycle8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число, кубический корень которого хотите вычислить: ");
                double n;
                n = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine(Cycle.CubicRoot(n));
            }
        }
    }
}
