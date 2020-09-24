  namespace GradeBook  {
    using System;
    using System.Collections.Generic;
    public class Book{
        private List<double> grades; 

        public string Name;
        public Book(string name){
            Name = name;
            grades = new List<double>(); 
        }
        public void AddGrade(double grade){
            grades.Add(grade);

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.LowGrade = double.MaxValue;
            result.HighGrade = double.MinValue;
            result.Average = 0.0;

            double total = 0.0;
            foreach (var grade in grades)
            {
                result.LowGrade = Math.Min(result.LowGrade,grade);
                result.HighGrade = Math.Max(result.HighGrade,grade);
                total += grade;
            }

            result.Average = total/grades.Count;

            return result;


        }
    }


  }
