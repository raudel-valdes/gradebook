using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program 
    {
        static void Main(string[] args)
        {   
            Book book = new Book("Raudel's Grade Book");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();

            //N1 formats the decimal place to one digit
            Console.WriteLine($"the lowest grade is {stats.Low:N1}");
            Console.WriteLine($"the highest grade is {stats.High:N1}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
