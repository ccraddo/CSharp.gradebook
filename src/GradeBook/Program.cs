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

            System.Console.WriteLine("");

            List<double> grades = new List<double>(){ 80.1,79,100,92.5};
            double result = 0;

            foreach (var g in grades)
            {
                result += g;    
            }

            double avg = result/ grades.Count;

            System.Console.WriteLine($"Average {avg:N2}");
        }
    }
}
