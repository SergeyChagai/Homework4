using MyLib;
using System;

namespace Branching3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[3] { a, b, c };
            int[] result = MyBranching.Increase(arr);

            for (int i = 0; i < result.Length; i++)
                Console.Write($"{result[i]} ");
        }
    }
}
