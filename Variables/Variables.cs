using System;

namespace Variables
{
    public static class MyEquals
    {
        public static int EqualsType1(int a, int b)
        {
            return ((5 * a - b * b) / (b - a));
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
                throw new Exception("Paraneter b can't be equal zero");
            else
            {
                double big_a = a;
                double big_b = b;
                return big_a / big_b;
            }
        }
        
        public static int RemainderOfTheDivision(int a, int b)
        {
            if (b == 0)
                throw new Exception("Paraneter b can't be equal zero");
            else
                return a % b;
        }

        public static double EqualsType2(int a, int b, int c)
        {
            if (a == 0)
                throw new Exception("Parameter \"a\" can't be equal zero");
            else
                return (Division((c - b), a));
        }

        public static string StraightLineEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 - x2 == 0)
                return ($"x = {x1}");
            double a = Division((y1 - y2), (x1 - x2));
           
            double b = y1 - a * x1;
            if (a != 0 && a != 1 && a != -1)                                                      
            {
                if (b > 0)
                    return ($"y = {a}x + {b}");
                else if (b == 0)
                    return ($"y = {a}x");
                else
                    return ($"y = {a}x {b}");
            }
            else if (a == 1)
            {
                if (b > 0)
                    return ($"y = x + {b}");
                else if (b == 0)
                    return ($"y = x");
                else
                    return ($"y = x {b}");
            }
            else if (a == -1)
            {
                if (b > 0)
                    return ($"y = -x + {b}");
                else if (b == 0)
                    return ($"y = -x");
                else
                    return ($"y = -x {b}");
            }
            else
                return ($"y = {b}");
        }
        public static double Sqrt(double a)
        {
            double s = 1;
            double i = 1;

            if (a < 0)
                throw new Exception("Parameter can't be negative");
            if (a == 0)
                return 0;
            while (s <= a && i > 0.0000000001)
            {
                if (s * s == a)
                    return s;
                else if ((s - 1 + i) * (s - 1 + i) == a)
                    return ((s - 1 + i));
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
            return s;
        }
    }
}