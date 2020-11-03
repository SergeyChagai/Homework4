using MyLib;
using System;

namespace Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b != 0)
            {
                int rep = MyVariables.EqualsType1(a, b);
                Console.WriteLine($"X равен {rep}");
            }
            else
                Console.WriteLine("Коэффициент b не должен быть равен нулю");

        }
    }
}
