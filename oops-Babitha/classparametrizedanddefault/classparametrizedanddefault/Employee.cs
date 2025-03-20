using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classparametrizedanddefault
{
    public class Employee
    {
        string name;
        double salary;
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

        public Employee(string name1, double salary1)
        {
            name = name1;
            salary = salary1;

        }
    }
}
