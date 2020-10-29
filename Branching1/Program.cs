using System;
using System.Threading.Tasks.Dataflow;
using MyLib;

namespace Branching1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MyBranching.Quarters(a, b));
        }
    }
}
