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
            double numberConsole = double.Parse(Console.ReadLine());
            Ivan IvanObj = new Ivan();
            IvanObj.number = numberConsole;
            //int faceCube = IvanObj.FaceCube();
            Console.Write("Face Cube: ");
            Console.WriteLine(IvanObj.FaceCube());
            
            Console.Write("Letters count: ");
            Console.WriteLine(IvanObj.lettersCount("Hello World"));
            Console.Write("Words count: ");
            Console.WriteLine(IvanObj.wordsCounter("Hello World"));
            Console.Write("Points: ");
            Console.WriteLine(IvanObj.points("Hello World", 2, 10));
        }
    }
}
