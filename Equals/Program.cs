using System;

namespace Homework1
{
    class Discriminant
    {
        public static int Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите три числа, которые будут являться коэффициентами квадратного уравнения типа \"a * x^2 + b * x + c = 0\"");
                double a = Convert.ToInt32(Console.ReadLine());
                double b = Convert.ToInt32(Console.ReadLine());
                double c = Convert.ToInt32(Console.ReadLine());

                if (a == 0 || a == 1 || b == 0 || c == 0)
                {
                    Console.WriteLine("Это не полное квадратное уравнение, я не такая программа");
                    return 1;
                }
                if (b * b - 4 * a * c < 0)
                {
                    Console.WriteLine("Корней нет");
                    return 0;
                }

                Console.WriteLine((-b + Sqrt(b * b - 4 * a * c)) / (2 * a));
                Console.WriteLine((-b - Sqrt(b * b - 4 * a * c)) / (2 * a));
                return 0;
            }
        }
        static double Sqrt(double a)
        {
            double s = 1;
            double i = 1;

            if (a < 0)
                return 0;
            if (a == 0)
                return 0;
            while (s <= a && i > 0.0000000001)
            {
                if (s * s == a)
                {
                    return s;
                    break;
                }
                else if ((s - 1 + i) * (s - 1 + i) == a)
                {
                    return (s - 1 + i);
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
                return s;
            else
                return 0;
        }
    }
}

