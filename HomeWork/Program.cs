﻿namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNumber21();
            Console.Write("  #21\n");
            MinNumber22();
            Console.Write("  #22\n");
            IfOneNumberIsTrue23();
            Console.Write("  #23\n");
            IfTwoNumberIsTwo24();
            Console.Write("  #24\n");
            TriangleSolve25();
            Console.Write("  #25\n");
            NumericalProgression27();
            Console.Write("  #26\n");
            NumericalProgression28();
            Console.Write("  #27\n");
            ToTheTop29();
            Console.Write("  #28\n");
            ToTheDown30();
            Console.Write("  #29\n");
            MaxNumber4digit31();
            Console.Write("  #30\n");
            MinNumber4digit32();
            Console.Write("  #31\n");
            IsNumberEqualOne33();
            Console.Write("  #32\n");
            IsFirstTwoEqualSecondTwo34();
            Console.Write("  #33\n");
            IfTheOneNumberEqualOtherThree35();
            Console.Write("  #34\n");
            IsTwoNumberIsOdd36();
            Console.Write("  #35\n");
            FirstTwoEqaulThird51();
            Console.Write("  #51\n");
            IsOneOfThisSame52();
            Console.Write("  #52\n");
            CalculateDivForNumber53();
            Console.Write("  #53\n");
            CalcMaxNumber54();
            Console.Write("  #54\n");
            CalcMinNumber55();
            Console.Write("  #55\n");
            IfThreeIsDivTooOther56();
            Console.Write("  #56\n");
            something57();
            Console.Write("  #57\n");
            IfAPlusBlesserFive58();
            Console.Write("  #58\n");
            ToGreater59();
            Console.Write("  #59\n");
            ToLower60();
            Console.Write("  #60\n");
            IfTwoIsEqualAnotherTwo61();
            Console.Write("  #61\n");
            DivSecondAndFinalNumber62();
            Console.Write("  #62\n");
            IfHaveOneOrNot63();
            Console.Write("  #63\n");
            IfSecondAndFinalEqual64();
            Console.Write("  #64\n");
            IfThirdAndFinalEqualTwenty65();
            Console.Write("  #65\n");
            IfTheFirstAndTheFinalHaveFour66();
            Console.Write("  #66\n");
            IfSumEqualPowAllNumbers67();
            Console.Write("  #67\n");
            IfTowGreaterThenOtherTwo68();
            Console.Write("  #68\n");
            IfSumGreaterThenTwenty69();
            Console.Write("  #69\n");
            IfSumGreaterThenTwoHandread70();
            Console.Write("  #70\n");
            Console.ReadKey();
        }
        public static void MaxNumber21()
        {
            int a = 5;
            int b = 12;
            int c = 9;
            if (a > b)
            {
                if (a > c)
                    Console.Write("a is the largest!");
                else
                    Console.Write("c is the largest!");
            }
            else if (b > c)
                Console.Write("b is the largest!");
            else
                Console.Write("c is the largest!");
        }
        public static void MinNumber22()
        {
            int a = 5;
            int b = 12;
            int c = 9;
            if (a < b)
            {
                if (a < c)
                    Console.Write("a is the smallest!");
                else
                    Console.Write("c is the smallest!");
            }
            else if (b > c)
                Console.Write("b is the smallest!");
            else
                Console.Write("c is the smallest!");
        }
        public static void IfOneNumberIsTrue23()
        {
            int a = 0;
            int b = 0;
            int c = 1;
            Console.Write(a == 1 || b == 1 || c == 1 ? true : false);
        }
        public static void IfTwoNumberIsTwo24()
        {
            int a = 0;
            int b = 2;
            int c = 2;
            Console.Write((a == 2 && b == 2) || (a == 2 && c == 2) || (b == 2 && c == 2) ? true : false);
        }
        public static void TriangleSolve25()
        {
            int a = 7;
            int b = 4;
            int c = 2;
            Console.Write((a + b > c) && (a + c > b) && (b + c > a) ? "y=1" : "y=2");
        }
        public static void NumericalProgression27()
        {
            int a = 8;
            int b = 6;
            int c = 4;
            int x = b - a;
            Console.Write((c == b + x) ? 1 : 2);
        }
        public static void NumericalProgression28()
        {
            int a = 16;
            int b = 32;
            int c = 64;
            int x = b / a;
            Console.Write((c == b * x) ? 1 : 2);
        }
        public static void ToTheTop29()
        {
            int a = 90;
            int b = 80;
            int c = 60;
            if (a > b && a > c && b > c)
                Console.Write($"{a},{b},{c}");
            else if (a > c && a > b && c > b)
                Console.Write($"{a},{c},{b}");
            else if (b > c && b > a && c > a)
                Console.Write($"{b},{c},{a}");
            else if (b > a && b > c && a > c)
                Console.Write($"{b},{a},{c}");
            else if (c > a && c > b && a > b)
                Console.Write($"{c},{a},{b}");
            else
                Console.Write($"{c},{b},{a}");
        }
        public static void ToTheDown30()
        {
            int a = 7;
            int b = 5;
            int c = 6;
            if (a < b && a < c && b < c)
                Console.Write($"{a},{b},{c}");
            else if (a < c && a < b && c < b)
                Console.Write($"{a},{c},{b}");
            else if (b < c && b < a && c < a)
                Console.Write($"{b},{c},{a}");
            else if (b < a && b < c && a < c)
                Console.Write($"{b},{a},{c}");
            else if (c < a && c < b && a < b)
                Console.Write($"{c},{a},{b}");
            else
                Console.Write($"{c},{b},{a}");
        }
        public static void MaxNumber4digit31()
        {
            int a = 11;
            int b = 14;
            int c = 13;
            int d = 12;
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                        Console.Write("a is the largest!");
                    else
                        Console.Write("d is largest!");
                }
            }
            if (b > c && b > d)
                Console.Write("b is the largest!");
            else if (c > d)
                Console.Write("c is the largest!");
        }
        public static void MinNumber4digit32()
        {
            int a = 11;
            int b = 14;
            int c = 13;
            int d = 12;
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                        Console.Write("a is the smallest!");
                    else
                        Console.Write("d is smallest!");
                }
            }
            if (b < c && b < d)
                Console.Write("b is the smallest!");
            else if (c < d)
                Console.Write("c is the smallest!");
        }
        public static void IsNumberEqualOne33()
        {
            int a = 11;
            int b = 14;
            int c = 13;
            int d = 12;
            Console.Write(a == 1 || b == 1 || c == 1 || d == 1 ? true : false);
        }
        public static void IsFirstTwoEqualSecondTwo34()
        {
            int a = 10;
            int b = 5;
            int c = 5;
            int d = 10;
            Console.Write(((a + b == c + d) || (a + c == d + b) || (a + d == b + c)) ? true : false);
        }
        public static void IfTheOneNumberEqualOtherThree35()
        {
            int a = 10;
            int b = 4;
            int c = 4;
            int d = 2;
            Console.Write((a == b + c + d || b == a + c + d || c == a + b + d || d == a + b + c) ? true : false);
        }
        public static void IsTwoNumberIsOdd36()
        {
            int a = 11;
            int b = 4;
            int c = 4;
            int d = 2;
            Console.Write(((a % 2 == 1) || (b % 2 == 1) || (c % 2 == 1) || (d % 2 == 1)) ? true : false);
        }
        public static void FirstTwoEqaulThird51()
        {
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            Console.Write(a + b == c ? true : false);
        }
        public static void IsOneOfThisSame52()
        {
            int t = 343;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            Console.Write((a == b || a == c || c == b) ? true : false);
        }
        public static void CalculateDivForNumber53()
        {
            int t = 343;
            int k = 520;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            int result = a + b + c;
            Console.Write((t / result) > k ? t / result : t / c);
        }
        public static void CalcMaxNumber54()
        {
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            if (a > b)
            {
                if (a > c)
                    Console.Write("a is the largest!");
                else
                    Console.Write("c is the largest!");
            }
            else if (b > c)
                Console.Write("b is the largest!");
            else
                Console.Write("c is the largest!");
        }
        public static void CalcMinNumber55()
        {
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            if (a < b)
            {
                if (a < c)
                    Console.Write("a is the smallest!");
                else
                    Console.Write("c is the smallest!");
            }
            else if (b > c)
                Console.Write("b is the smallest!");
            else
                Console.Write("c is the smallest!");
        }
        public static void IfThreeIsDivTooOther56()
        {
            float t = 132;
            float a = t / 100;
            float b = (t / 10) % 10;
            float c = t % 10;
            float d = a + b + c;
            float z = d / t;
            Console.Write(c > b ? z : t);
        }
        public static void something57()
        {
            float t = 217;
            float a = t / 100;
            float b = (t / 10) % 10;
            float c = t % 10;
            Console.Write(t > 300 ? b / c : a / c);
        }
        public static void IfAPlusBlesserFive58()
        {
            char f;
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            Console.Write(a + b < 5 ? f = 'a' : f = 'b');
        }
        public static void ToGreater59()
        {
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            if (a > b && a > c && b > c)
                Console.Write($"{a},{b},{c}");
            else if (a > c && a > b && c > b)
                Console.Write($"{a},{c},{b}");
            else if (b > c && b > a && c > a)
                Console.Write($"{b},{c},{a}");
            else if (b > a && b > c && a > c)
                Console.Write($"{b},{a},{c}");
            else if (c > a && c > b && a > b)
                Console.Write($"{c},{a},{b}");
            else
                Console.Write($"{c},{b},{a}");
        }
        public static void ToLower60()
        {
            int t = 347;
            int a = t / 100;
            int b = (t / 10) % 10;
            int c = t % 10;
            if (a < b && a < c && b < c)
                Console.Write($"{a},{b},{c}");
            else if (a < c && a < b && c < b)
                Console.Write($"{a},{c},{b}");
            else if (b < c && b < a && c < a)
                Console.Write($"{b},{c},{a}");
            else if (b < a && b < c && a < c)
                Console.Write($"{b},{a},{c}");
            else if (c < a && c < b && a < b)
                Console.Write($"{c},{a},{b}");
            else
                Console.Write($"{c},{b},{a}");
        }
        public static void IfTwoIsEqualAnotherTwo61()
        {
            int t = 1324;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            Console.Write(a + b == c + d ? true : false);
        }
        public static void DivSecondAndFinalNumber62()
        {
            int t = 1324;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            int e = (b + d != 0) ? t / (b + d) : 0;
            int f = (a + c != 0) ? t / (a + c) : 0;
            Console.Write(t < 5000 ? e : f);
        }
        public static void IfHaveOneOrNot63()
        {
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            Console.Write((a == 1 || b == 1 || c == 1 || d == 1) ? 1 : 0);
        }
        public static void IfSecondAndFinalEqual64()
        {
            char y;
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            Console.Write(c+d == 5 ? y = 's' : y = 'd');
        }
        public static void IfThirdAndFinalEqualTwenty65()
        {
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            Console.Write(c * d == 12 ? "y=12" : "y=0");
        }
        public static void IfTheFirstAndTheFinalHaveFour66()
        {
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10;
            Console.Write((a == 4 && c == 4) ? "YES" : "NO");
        }
        public static void IfSumEqualPowAllNumbers67()
        {
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10
            int sum = a + b + c + d;
            Console.Write((Math.Pow(sum,2) == t) ? "YES" : "NO");
        }
        public static void IfTowGreaterThenOtherTwo68()
        {
            int t = 3424;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10
            Console.Write(d > c ? d * b : a * c);
        }
        public static void IfSumGreaterThenTwenty69()
        {
            int t = 3424;
            int y;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10
            int sum = a * b * c * d;
            Console.Write(sum > 20 ? y = 1 : y = 0);
        }
        public static void IfSumGreaterThenTwoHandread70()
        {
            int t = 3424;
            int y;
            int a = t / 1000;
            int b = (t / 100) % 10;
            int c = (t / 10) % 10;
            int d = t % 10
            int sum = a * b * c * d;
            Console.Write(sum > 200 ? y = 0 : y = 1);
        }
    }
}