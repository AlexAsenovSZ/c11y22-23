using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zadacha1a(3, 3));
        }
        static long Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        static void ToBin(int num)
        {
            if (num == 0)
            {
                Console.Write('0');
                return;
            }
            ToBin(num / 2);
            Console.Write(num % 2);
        }

        static int Binom(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }
            else
            {
                return Binom(n - 1, k) + Binom(n - 1, k - 1); 
            }
        }

        static double Sum1(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Math.Sqrt(n + Sum1(n - 1));
            }
        }
        static double Sum2(int n)
        {
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = Math.Sqrt(s + i);
            }
            return s;
        }
        static double Zadacha1a(double x, double n)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return Math.Pow((x + 1), (n + 1));
            }
        }
    }
}
