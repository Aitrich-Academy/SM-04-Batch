using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classparametrizedanddefault
{
   public class Student
    {
        string name;
        double grade;
        public Student()
        {
            name = "Unknown";
            grade = 0;
        }
        public Student(string name1, double grade1)
        {
            name = name1;
            grade = grade1;
        }
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
