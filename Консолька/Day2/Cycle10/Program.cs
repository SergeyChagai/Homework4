using MyLib;
using System;

namespace Cycle10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите целое положительное число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                bool flag = false;

                if (a < 0)
                    flag = true;
                Console.Write(Cycle.ReverseNum(a));
                if (flag == true)
                    Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}
