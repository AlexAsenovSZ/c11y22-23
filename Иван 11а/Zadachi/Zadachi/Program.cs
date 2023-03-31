using System;
using System.Linq;

namespace Zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            DecToBin(23);
        }

        public static void kvUravneinie()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = (b * b) - (4 * a * c);

            if (D > 0)
            {
                double x1 = (-b + (Math.Sqrt(D) / (2 * a)));
                double x2 = (-b - (Math.Sqrt(D) / (2 * a)));
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (D == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Няма реални корени!");
            }
        }

        public static void zad2()
        {
            Random r = new Random();
            int random = r.Next(1, 49);
            Console.WriteLine(random);
        }

        static void DecToBin(int n)
        {
            if (n == 0)
            {
                return;
            }
            DecToBin(n / 2);
            Console.WriteLine(n % 2);
        }

        public static void Zad7()
        {

        }
    }
}
