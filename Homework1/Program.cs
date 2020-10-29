using System;
class Variables
{
    static int Main()
    {
        Console.WriteLine("Введите координаты точки А");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());

        if (x1 - x2 == 0)
        {
            Console.WriteLine($"x = {x1}");
            return 0;
        }
        int a = (y1 - y2) / (x1 - x2);
        if ((y1 - y2) % (x1 - x2) != 0)
        {
            Console.WriteLine("Коэффиценты дробные, завершение программы");
            return 1;
        }
        int b = y1 - a * x1;
        if (a != 0 && a != 1 && a != -1)                                                      //это чтобы ответ был красивым при любых значениях коэффицментов
        {
            if (b > 0)
                Console.WriteLine($"y = {a}x + {b}");
            else if (b == 0)
                Console.WriteLine($"y = {a}x");
            else
                Console.WriteLine($"y = {a}x {b}");
        }
        else if (a == 1)
        {
            if (b > 0)
                Console.WriteLine($"y = x + {b}");
            else if (b == 0)
                Console.WriteLine($"y = x");
            else
                Console.WriteLine($"y = x {b}");
        }
        else if (a == -1)
        {
            if (b > 0)
                Console.WriteLine($"y = -x + {b}");
            else if (b == 0)
                Console.WriteLine($"y = -x");
            else
                Console.WriteLine($"y = -x {b}");
        }
        else
        {
            Console.WriteLine($"y = {b}");
        }
        return 0;
    }
}
