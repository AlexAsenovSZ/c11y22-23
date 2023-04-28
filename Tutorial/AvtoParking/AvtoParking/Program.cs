using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking Pmol = new Parking();
            string input;
            while (true)
            {
                int number = 0;
                Console.WriteLine("Welcome!");
                Console.Write("enter (t) or exit (f): ");
                input = Console.ReadLine();
                if (input == "t")
                {
                    number = Pmol.Enter();
                    Console.Write("Parking number: {0}",number);
                }
                else
                {
                    Pmol.Exit();
                }
                Console.WriteLine("Working is parking (t/f)");
                input = Console.ReadLine();
                if (input == "f")
                {
                    break;
                }

            }

        }
    }
}
