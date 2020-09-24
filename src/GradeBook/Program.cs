using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // further change

            var book = new Book("Colin's book");
            
            book.AddGrade(89.5);
        
            var stats = book.GetStatistics();

            System.Console.WriteLine($"Lowest grade ={stats.LowGrade}");
            System.Console.WriteLine($"Higest grade ={stats.HighGrade}");
            System.Console.WriteLine($"Average grade ={stats.Average}");
           
        }
    }
}
