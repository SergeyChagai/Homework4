using System;

namespace Sqrt
{
    class Branching
    {
        static double Sqrt(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число, из которого хотите извлечь корень: ");
                int a = Convert.ToInt32(Console.ReadLine());
                double s = 1;
                double i = 1;

                if (a < 0)
                    Console.WriteLine("Корень не извлечь, отрицательное число");
                if (a == 0)
                    Console.WriteLine("0");
                while (s <= a && i > 0.0000000001 )
                {
                    if (s * s == a)
                    {
                        Console.WriteLine(s);
                        break;
                    }
                    else if ((s - 1 + i) * (s - 1 + i) == a)
                    {
                        Console.WriteLine((s - 1 + i));
                        break;
                    }
                    else if (s * s < a)
                        s = s + i;
                    else if (s * s > a)
                    {
                        s = s - i + i / 10;
                        i /= 10;
                    }
                    else if ((s + i) * (s + i) < a)
                    {
                        s = s - 1 + i;
                        continue;
                    }
                    else if ((s - 1 + i) * (s - 1 + i) > a)
                    {
                        i /= 10;
                        continue;
                    }

                }
                if (i <= 0.0000000001)
                    Console.WriteLine(s);
            }
        }
    }
}


