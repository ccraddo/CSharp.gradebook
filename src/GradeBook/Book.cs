  namespace GradeBook  {
    using System;
    using System.Collections.Generic;
    class Book{
        private List<double> grades; 

        private string name;
        public Book(string name){
            this.name = name;
            grades = new List<double>(); 
        }
        public void AddGrade(double grade){
            grades.Add(grade);

        }

        internal void ShowStatistics()
        {

            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            double result = 0.0;

            foreach (var grade in grades)
            {
                lowGrade = Math.Min(lowGrade,grade);
                highGrade = Math.Max(highGrade,grade);
                result += grade;
            }

            double avg = result/=grades.Count;

            System.Console.WriteLine($"Lowest grade ={lowGrade}");
            System.Console.WriteLine($"Higest grade ={highGrade}");
            System.Console.WriteLine($"Average grade ={avg}");

        }
    }


  }
