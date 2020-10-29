using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace MyLib
{
    public static class MyBranching
    {
        public static int Condition1(int a, int b)
        {
            if (a > b)
                return (a + b);
            else if (a == b)
                return (a * b);
            else
                return (a - b);
        }

        public static string Quarters(int x, int y)
        {
            if (x > 0 && y > 0)
                return ("Точка в первой четверти (верхний правый угол)");
            if (x < 0 && y > 0)
                return ("Точка во второй четверти (верхний левый угол)");
            if (x < 0 && y < 0)
                return ("Точка в третьей четверти (нижний левый угол)");
            if (x > 0 && y < 0)
                return ("Точка в четвертой четверти (нижний правый угол)");
           else
                return ("Точка в начале координат");
        }

        public static int[] Increase(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int max = arr[i];
                for (int j = i; j < arr.Length; j++)
                    if (arr[j] > max)
                        MyEquals.Swap(arr[j], max)
else
                arr[i] = max;
            }
            return arr;
        }
    }
}
