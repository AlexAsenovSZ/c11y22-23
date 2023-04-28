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
                Console.WriteLine("Welcome!");
                Console.Write("enter (t) or exit (f): ");
                input = Console.ReadLine();
                if (input == "t")
                {
                    Pmol.Enter();
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
