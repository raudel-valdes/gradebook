using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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
        
        public Statistics GetStatistics() 
        {
            var result = new Statistics();
            result.Average = 0.0;

            //Here we make the high have the lowest double value
            //and the LOW have the highest double value for when
            //when we go compare we can get the values that we 
            //really are looking for.
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(double grade in grades) {

                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        //These are instance field and implicit typing can't be used
        private List<double> grades;
        private string name;
    }
}