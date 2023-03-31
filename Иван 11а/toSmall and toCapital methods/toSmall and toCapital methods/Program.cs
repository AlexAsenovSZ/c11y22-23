using System;

namespace toSmall_and_toCapital_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            charArray s = new charArray("HELlo");
            Console.WriteLine(s.toCapital());
        }
    }
}
