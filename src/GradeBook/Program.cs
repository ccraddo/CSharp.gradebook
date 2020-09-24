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
        
            book.ShowStatistics();
           
        }
    }
}
