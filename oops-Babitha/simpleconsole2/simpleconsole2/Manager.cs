using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsole2
{
   public class Manager:Employee
    {
        public int TeamSize=10;
        //public Manager() { 
        //}
        public void DisplayDetails(int Id,string Name, string department)
        {
            Console.WriteLine("Employee id:" + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee department:" + department);
            Console.WriteLine("Team Size :" + TeamSize);
        }
    }
}
