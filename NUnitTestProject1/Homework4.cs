using MyLib;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Homework4
{
    public class Variables
    {
        [TestCase (12, -23, 13)]
        [TestCase (0, 567, -567)]
        [TestCase (-534, 0, -5)]
        [TestCase (456, -1358, 1015)]

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
        [TestCase(5, 3, 2 ,0, "y = x -2")]
        [TestCase(56, 89, 1235, 95, "y = 0,005089058524173028x + 88,7150127226463")]
        [TestCase(5, 89, 5, 9815, "x = 5")]
        public void StraightLineEquation(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = MyVariables.StraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

    }

    public class Branching
    {
        [TestCase(0, 0, 0)]
        [TestCase(1500000, 500000, 2000000)]
        [TestCase(-500000, 1500000, -2000000)]
        [TestCase(1000, 1000, 1000000)]
        [TestCase(-1000, -1000, 1000000)]
        public void Condition1(int a, int b, int expected)
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
        public void Quarters(int x, int y, string expected)
        {
            string actual = MyBranching.Quarters(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 651, 54, 68541 }, new int[] { 54, 651, 68541 })]
        [TestCase(new int[] { 86, -6841, -1500000 }, new int[] { -1500000, -6841, 86 })]
        [TestCase(new int[] { 0, 0, 0}, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 2000000, 500000, 0 }, new int[] { 0, 500000, 2000000})]
        [TestCase(new int[] { 0, -500000, -2000000 }, new int[] { -2000000, -500000, 0 })]
        public void Increase(int[] arr, int[] expected)
        {
            int[] actual = MyBranching.Increase(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 2)]
        [TestCase(121, 11)]
        [TestCase(2000000, 1414.2135623730950488016887242097)]
        [TestCase(0, 0)]
        [TestCase(9, 3)]
        public void Sqrt_Positive(double a, double expected)
        {
            double actual = MyBranching.Sqrt(a);
            Assert.AreEqual(expected, actual, 0.00000001);
        }

        [Test]
        public void Sqrt_Negative()
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
        public void CallingNumber(int a, string expected)
        {
            string actual = MyBranching.CallingNumber(a);
            Assert.AreEqual(expected, actual);
        }


    }

}