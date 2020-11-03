using MyLib;
using System;

namespace Branching5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите двузначное число");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(MyBranching.CallingNumber(a));
            }
        }
    }
}
