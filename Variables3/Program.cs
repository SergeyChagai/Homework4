using System;
using Variables;

namespace Variables3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Результат деления a на b = {MyEquals.Division(a, b)}");        //я понимаю, что смысла в данном случае делать метод ровно ноль, но я следую завету single responsibility)
            Console.WriteLine($"Остаток от деления a на b = {MyEquals.RemainderOfTheDivision(a, b)}");
        }
    }
}
