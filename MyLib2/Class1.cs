using System;
using System.Reflection.Metadata.Ecma335;

namespace MyLib2
{
    public static class Cycle
    {
        public static int Degree(int a)
        {
            int degree = 1;
            for (int i = 0; i < a; i++)
                degree = degree * a;
            return degree;
        }
    }
}
