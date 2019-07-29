using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //This is a constructor and it needs to have the same
        //name as your class and it cannot have a return type.
        //. A constructor gives you acces to 
        //the initialization of your objects. in here we will
        // set the values of the members of an oject to either 
        //default or to user-defined values. This construcor
        //requires an attribute of name to be sent whenever a new
        //object gets created.
        public Book(string name) 
        {
            grades = new List<double>();
            
            //we use this whenever we want to acces a value from the
            //class. WE no longer use it a much but essentially it is being
            //used behind the scenes when you acces a value within the class.
            //There are special case scenerios where you still have to use
            //this and this is one of those cases. In order to differentiate 
            //the name stored in the class from the name being sent  must 
            //use the THIS. to point to the class value.
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        
        public void showStatistics() 
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(double number in grades) {

                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            result /= grades.Count;


            //N1 formats the decimal place to one digit
            Console.WriteLine($"the lowest grade is {lowGrade:N1}");
            Console.WriteLine($"the highest grade is {highGrade:N1}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        //These are instance field and implicit typing can't be used
        private List<double> grades;
        private string name;
    }
}