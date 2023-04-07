using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namiraneNaSimvoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Ivan s = new Ivan();
            Console.Write("Letters count: ");
            Console.WriteLine(s.lettersCount("Hello World"));
            Console.Write("Words count: ");
            Console.WriteLine(s.wordsCounter("Hello World"));
            Console.Write("Points: ");
            Console.WriteLine(s.points("Hello World", 2, 10));
        }
    }
}
