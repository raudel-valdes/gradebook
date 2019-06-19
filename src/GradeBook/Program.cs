using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Using string concatination
            Console.WriteLine("Hello " + args[0] + "!");

            //Using string interpolation
            Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
