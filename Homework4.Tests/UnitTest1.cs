using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using MyLib;
using NUnit.Framework;
using System;

namespace Homework4.Tests
{
    public class Variables
    {
        [TestCase(12, -23, 13)]
        [TestCase(0, 567, -567)]
        [TestCase(-534, 0, -5)]
        [TestCase(456, -1358, 1015)]

        public void EqualsType1_Positive(int a, int b, int expected)
        {
            int actual = MyVariables.EqualsType1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void EqualsType1_Negative()
        {
            try
            {
                MyVariables.EqualsType1(1, 1);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(12, -23)]
        [TestCase(4561, 987132)]
        [TestCase(-651685, 0)]
        [TestCase(-56481, -238453)]
        [TestCase(0, 0)]
        public void Swap(int a, int b)
        {
            int temp1 = a;
            int temp2 = b;

            MyVariables.Swap(ref a, ref b);
            if (a == temp2 && b == temp1)
                Assert.Pass();
            else
                Assert.Fail();
        }

        [TestCase(1233, 13, 94.84615384615384)]
        [TestCase(-12358, -646846, 0.0191050110845549)]
        public void Division_Positive(int a, int b, double expected)
        {
            double actual = MyVariables.Division(a, b);
            Assert.AreEqual(expected, actual, 0.0000000001);
        }

        [Test]
        public void Division_Negative()
        {
            try
            {
                MyVariables.Division(1, 0);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(155135, 654, 137)]
        [TestCase(-138516, -14353, -9339)]
        [TestCase(2005158, 84, 78)]
        [TestCase(-468680, 6161, -444)]
        public void ReminderOfDivision_Positive(int a, int b, int expected)
        {
            int actual = MyVariables.RemainderOfTheDivision(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReminderOfDivision_Negative()
        {
            try
            {
                MyVariables.RemainderOfTheDivision(12, 0);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(35, 954, 1864359, 53240.1428571)]
        [TestCase(26, 645896, -1358946, -77109.3076923)]
        [TestCase(-68, -6548, -15684, 134.352941176)]
        [TestCase(6548, 546, 654, 0.01649358582)]
        public void EqualsType2_Positive(int a, int b, int c, double expected)
        {
            double actual = MyVariables.EqualsType2(a, b, c);
            Assert.AreEqual(expected, actual, 0.0000001);
        }

        [Test]
        public void EqualsType2_Negative()
        {
            try
            {
                MyVariables.EqualsType2(0, 12, 34);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(-56, 89, 651, -465, "y = -0,7835926449787836x + 45,11881188118812")]
        [TestCase(-351, -9871, -8413, -358, "y = -1,1799801538079882x -10285,173033986604")]
        [TestCase(5, 3, 2, 0, "y = x -2")]
        [TestCase(56, 89, 1235, 95, "y = 0,005089058524173028x + 88,7150127226463")]
        [TestCase(5, 89, 5, 9815, "x = 5")]
        public void StraightLineEquation(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = MyVariables.StraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

    }

    public static class Branching
    {
        [TestCase(0, 0, 0)]
        [TestCase(1500000, 500000, 2000000)]
        [TestCase(-500000, 1500000, -2000000)]
        [TestCase(1000, 1000, 1000000)]
        [TestCase(-1000, -1000, 1000000)]
        public static void Condition1(int a, int b, int expected)
        {
            int actual = MyBranching.Condition1(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(435, 45645, "Точка в первой четверти (верхний правый угол)")]
        [TestCase(-651, 6544, "Точка во второй четверти (верхний левый угол)")]
        [TestCase(-6541, -8641, "Точка в третьей четверти (нижний левый угол)")]
        [TestCase(65461, -654, "Точка в четвертой четверти (нижний правый угол)")]
        [TestCase(-571, 0, "Точка на оси абсцисс слева")]
        [TestCase(65841, 0, "Точка на оси абсцисс справа")]
        [TestCase(0, 684, "Точка на оси ординат сверху")]
        [TestCase(0, -680, "Точка на оси ординат снизу")]
        [TestCase(0, 0, "Точка в начале координат")]
        public static void Quarters(int x, int y, string expected)
        {
            string actual = MyBranching.Quarters(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 651, 54, 68541 }, new int[] { 54, 651, 68541 })]
        [TestCase(new int[] { 86, -6841, -1500000 }, new int[] { -1500000, -6841, 86 })]
        [TestCase(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 2000000, 500000, 0 }, new int[] { 0, 500000, 2000000 })]
        [TestCase(new int[] { 0, -500000, -2000000 }, new int[] { -2000000, -500000, 0 })]
        public static void Increase(int[] arr, int[] expected)
        {
            int[] actual = MyBranching.Increase(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2)]
        [TestCase(121, 11)]
        [TestCase(2000000, 1414.2135623730950488016887242097)]
        [TestCase(0, 0)]
        [TestCase(9, 3)]
        public static void Sqrt_Positive(double a, double expected)
        {
            double actual = MyBranching.Sqrt(a);
            Assert.AreEqual(expected, actual, 0.00000001);
        }

        [Test]
        public static void Sqrt_Negative()
        {
            try
            {
                MyBranching.Sqrt(-1);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(95, "девяносто пять\n")]
        [TestCase(12, "двенадцать\n")]
        [TestCase(60, "шестьдесят \n")]
        [TestCase(10, "десять\n")]
        [TestCase(56, "пятьдесят шесть\n")]
        public static void CallingNumber(int a, string expected)
        {
            string actual = MyBranching.CallingNumber(a);
            Assert.AreEqual(expected, actual);
        }
    }
    public static class Cycle
    {
        [TestCase(2,2,4)]
        [TestCase(0,0,1)]
        [TestCase(0,1,0)]
        [TestCase(11,2,121)]
        public static void Degree(int num, int pow, double exepted)
        {
            double actual = MyCycle.Degree(num, pow);
            Assert.AreEqual(exepted, actual);
        }

        [Test]
        public static void DegreeNegative()
        {
            try
            {
                MyCycle.Degree(2, -8);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(7, 100, 1)]
        [TestCase(10, 100, 2)]
        [TestCase(9,100,3)]
        [TestCase(100, 100, 4)]
        [TestCase(100, 90, 5)]
        public static void AmountOfNumWhoDivide(int num, int rightboarder, int numberOfCase)
        {
            int[] actual = MyCycle.NumWhoDivide(num, rightboarder);
            Assert.AreEqual(ArrayMock1(numberOfCase), actual);
        }

        public static int[] ArrayMock1(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 7,14,21,28,35,42,49,56,63,70,77,84,91,98 };
                    return arr;
                case 2:
                    arr = new int[] {10,20,30,40,50,60,70,80,90,100 };
                    return arr;
                case 3:
                    arr = new int[] { 9,18,27,36,45,54,63,72,81,90,99};
                    return arr;
                case 4:
                    arr = new int[] { 100};
                    return arr;
                case 5:
                    arr = new int[] { };
                    return arr;
                default:
                    throw new Exception();
            }
        }

        [TestCase(10, 3)]
        [TestCase(2, 1)]
        [TestCase(20, 4)]
        [TestCase(40001, 200)]
        public static void AmountOfNumSquareLessThan(int a, int expected)
        {
            int actual = MyCycle.AmountOfNumSquareLessThan(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public static void AmountOfNumSquareLessThanNegative(int a)
        {
            try
            {
                MyCycle.AmountOfNumSquareLessThan(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(7, 1)]
        [TestCase(20, 10)]
        [TestCase(45154, 22577)]
        [TestCase(45153, 15051)]
        public static void BiggerDividerOf(int a, int expected)
        {
            int actual = MyCycle.BiggerDividerOf(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7,0,8,7)]
        [TestCase(7,-20,20,0)]
        [TestCase(7,0,0,0)]
        [TestCase(7,20,0,21)]
        public static void SumOfDivisibleNum(int div, int left, int right, int expected)
        {
            int actual = MyCycle.SumOfDivisibleNum(div, left, right);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(30, 832040)]
        public static void NumOfFibonacci(int n, int expected)
        {
            int actual = MyCycle.NumOfFibonacci(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7,14,7)]
        [TestCase(968438, 3217, 1)]
        [TestCase(73217, 968438,1)]
        [TestCase(6515, 2091315, 6515)]
        public static void GreatestCommonFactor(int a, int b, int expected)
        {
            int actual = MyCycle.GreatestCommonFactor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27,3)]
        [TestCase(125,5)]
        [TestCase(-512,-8)]
        [TestCase(-804357, -93)]
        public static void CubicRoot(double n, double expected)
        {
            double actual = MyCycle.CubicRoot(n);
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestCase(354125, 4)]
        [TestCase(98413, 3)]
        [TestCase(-32168, 2)]
        [TestCase(0, 0)]
        public static void ImpairDigits(int a, int expected)
        {
            int actual = MyCycle.ImpairDigits(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 321)]
        [TestCase(684315, 513486)]
        [TestCase(35486, 68453)]
        [TestCase(-54274, 47245)]
        public static void ReverseNum(int a, int expected)
        {
            int actual = MyCycle.ReverseNum(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,13, 5)]
        [TestCase(111,122, 5)]
        [TestCase(110, 115, 1)]
        [TestCase(1111, 1120, 3)]
        [TestCase(13, 1, 5)]
        [TestCase(10, -10, 8)]
        public static void PairImpair(int a, int n, int expected)
        {
            int actual = MyCycle.PairImpair(a, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1234, 56781, true)]
        [TestCase(1234, 56789, false)]
        [TestCase(-1234, 56789, false)]
        [TestCase(1234, -56781, true)]
        public static void SameDigits(int a, int b, bool expected)
        {
            bool actual = MyCycle.SameDigits(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
    public class Array
    {
        [TestCase(1, 1)]
        [TestCase(4, -1)]
        [TestCase(5, 90)]
        static public void Min_Number(int case_arr, int expected)
        {
            int current = MyArray.MinNumber(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [Test]
        static public void Min_Number_Negative()
        {
            int[] arr = new int[] { };
            try
            {
                MyArray.MinNumber(arr);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 6)]
        [TestCase(4, 5)]
        [TestCase(5, 6545)]
        static public void Max_Number(int case_arr, int expected)
        {
            int current = MyArray.MaxNumber(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [TestCase(1, 0)]
        [TestCase(4, 5)]
        [TestCase(5, 3)]
        static public void IndexMin(int case_arr, int expected)
        {
            int current = MyArray.IndexMin(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [TestCase(1, 5)]
        [TestCase(4, 4)]
        [TestCase(5, 2)]
        static public void IndexMax(int case_arr, int expected)
        {
            int current = MyArray.IndexMax(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [TestCase(1, 12)]
        [TestCase(4, 5)]
        [TestCase(5, 441)]
        [TestCase(6, 0)]
        [TestCase(7, 0)]
        static public void SumOfNumbersWhoHasImpairIndex(int case_arr, int expected)
        {
            int current = MyArray.SumOfNumbersWhoHasImpairIndex(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        static public void ReverseArray(int case_arr, int case_reversed_arr)
        {
            int[] current = MyArray.ReverseArray(ArrayMock(case_arr));
            Assert.AreEqual(ReversedArrayMock(case_reversed_arr), current);
        }

        [TestCase(1, 3)]
        [TestCase(2, 4)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 4)]
        [TestCase(6, 0)]
        static public void NumberOfImpairElements(int case_arr, int expected)
        {
            int current = MyArray.NumberOfImpairElements(ArrayMock(case_arr));
            Assert.AreEqual(expected, current);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        static public void HalfSwap(int case_arr, int case_expected_arr)
        {

            int[] current = MyArray.HalfSwap(ArrayMock(case_arr));
            Assert.AreEqual(ExpectedArrayMock(case_expected_arr), current);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        [TestCase(8, 8)]
        static public void SortIncrease(int case_arr, int case_sorted_arr)
        {
            int[] current = MyArray.SortIncrease(ArrayMock(case_arr));
            Assert.AreEqual(SortedIncreaseArrayMock(case_sorted_arr), current);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        [TestCase(5, 5)]
        static public void SortDecrease(int case_arr, int case_sorted_arr)
        {
            int[] current = MyArray.SortDecrease(ArrayMock(case_arr));
            Assert.AreEqual(SortedDecreaseArrayMock(case_sorted_arr), current);
        }
        static public int[] ArrayMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 1, 2, 3, 4, 5, 6 };
                    return arr;
                case 2:
                    arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                    return arr;
                case 3:
                    arr = new int[] { 1, 2, 3, 4, 5 };
                    return arr;
                case 4:
                    arr = new int[] { 1, 2, 3, 4, 5, -1 };
                    return arr;
                case 5:
                    arr = new int[] { 111, 351, 6545, 90, 6515 };
                    return arr;
                case 6:
                    arr = new int[] { };
                    return arr;
                case 7:
                    arr = new int[] { 1 };
                    return arr;
                case 8:
                    arr = new int[] { 9, 7, 8, 3, 5, 4, 1, 6, 2 };
                    return arr;
                default:
                    throw new Exception();
            }
        }

        static public int[] ExpectedArrayMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 4, 5, 6, 1, 2, 3 };
                    return arr;
                case 2:
                    arr = new int[] { 5, 6, 7, 4, 1, 2, 3 };
                    return arr;
                case 3:
                    arr = new int[] { 4, 5, 3, 1, 2 };
                    return arr;
                default:
                    throw new Exception();
            }
        }

        static public int[] ReversedArrayMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 6, 5, 4, 3, 2, 1 };
                    return arr;
                case 2:
                    arr = new int[] { 7, 6, 5, 4, 3, 2, 1 };
                    return arr;
                case 3:
                    arr = new int[] { 5, 4, 3, 2, 1 };
                    return arr;
                case 4:
                    arr = new int[] { -1, 5, 4, 3, 2, 1 };
                    return arr;
                default:
                    throw new Exception();
            }

        }
        static public int[] SortedIncreaseArrayMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 1, 2, 3, 4, 5, 6 };
                    return arr;
                case 2:
                    arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                    return arr;
                case 3:
                    arr = new int[] { 1, 2, 3, 4, 5 };
                    return arr;
                case 4:
                    arr = new int[] { -1, 1, 2, 3, 4, 5 };
                    return arr;
                case 5:
                    arr = new int[] { 90, 111, 351, 6515, 6545 };
                    return arr;
                case 8:
                    arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    return arr;
                default:
                    throw new Exception();
            }
        }

        static public int[] SortedDecreaseArrayMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[] { 6, 5, 4, 3, 2, 1 };
                    return arr;
                case 2:
                    arr = new int[] { 7, 6, 5, 4, 3, 2, 1 };
                    return arr;
                case 3:
                    arr = new int[] { 5, 4, 3, 2, 1 };
                    return arr;
                case 4:
                    arr = new int[] { 5, 4, 3, 2, 1, -1 };
                    return arr;
                case 5:
                    arr = new int[] { 6545, 6515, 351, 111, 90 };
                    return arr;
                default:
                    throw new Exception();
            }
        }
    }

    static public class Array2D
    {
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3, -6841)]
        static public void MinNumber(int case_tab, int expected)
        {
            int actual = My2DArray.MinNumber(Array2DMock(case_tab));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 9)]
        [TestCase(3, 789)]
        static public void MaxNumber(int case_tab, int expected)
        {
            int actual = My2DArray.MaxNumber(Array2DMock(case_tab));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        static public void IndexOfMinNumber(int case_tab, int case_coordinates_of_min)
        {
            int[] actual = My2DArray.IndexOfMinNumber(Array2DMock(case_tab));
            Assert.AreEqual(CoordinatesOfMinMock(case_coordinates_of_min), actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        static public void IndexOfMaxNumber(int case_tab, int case_coordinates_of_max)
        {
            int[] actual = My2DArray.IndexOfMaxNumber(Array2DMock(case_tab));
            Assert.AreEqual(CoordinatesOfMaxMock(case_coordinates_of_max), actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        static public void AmountOfNumbersWhoIsBiggerOfTheirNeighbors(int case_tab, int expected)
        {
            int actual = My2DArray.AmountOfNumbersWhoIsBiggerOfTheirNeighbors(Array2DMock(case_tab));
            Assert.AreEqual(expected, actual);
        }
        static public int[,] Array2DMock(int a)
        {
            int[,] tab;
            switch (a)
            {
                case 1:
                    tab = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                    return tab;
                case 2:
                    tab = new int[,] { { 7, 8, 9 }, { 4, 5, 6 }, { 1, 2, 3 } };
                    return tab;
                case 3:
                    tab = new int[,] { { -153, 56, 789 }, { -789, 8, 684 }, { -684, -6841, -321 } };
                    return tab;
                case 4:
                    tab = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
                    return tab;
                default:
                    throw new Exception();
            }
        }
        static public int[] CoordinatesOfMinMock(int a)
        {
            int[] coordinates;
            switch (a)
            {
                case 1:
                    coordinates = new int[2] { 0, 0 };
                    return coordinates;
                case 2:
                    coordinates = new int[2] { 2, 0 };
                    return coordinates;
                case 3:
                    coordinates = new int[2] { 2, 1 };
                    return coordinates;
                default:
                    throw new Exception();
            }
        }

        static public int[] CoordinatesOfMaxMock(int a)
        {
            int[] coordinates;
            switch (a)
            {
                case 1:
                    coordinates = new int[2] { 2,2};
                    return coordinates;
                case 2:
                    coordinates = new int[2] { 0,2};
                    return coordinates;
                case 3:
                    coordinates = new int[2] { 0,2 };
                    return coordinates;
                default:
                    throw new Exception();
            }
        }

        static public int[,] TransposeMatrixMock(int a)
        {
            int[,] arr;
            switch (a)
            {
                case 1:
                    arr = new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
                    return arr;
                case 2:
                    arr = new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
                    return arr;
                case 3:
                    arr = new int[,] { { -153, -789, -684 }, { 56, 8, -6841 }, { 789, 684, -321 } };
                    return arr;
                case 4:
                    arr = new int[,] { { 1, 4 }, { 2, 5 }, { 3, 6 } };
                    return arr;
                default:
                    throw new Exception();
            }
        }
    }
}