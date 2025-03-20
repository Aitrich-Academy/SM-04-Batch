using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleconsole2
{
   public class Employee:Person

    {
        public int Id;
        public string Name;
        public string department;
        public void DisplayDetails()
        {
            Console.WriteLine("Employee id:" + Id);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee department:" + department);
        }
        public override void GetRole()
        {
            Console.WriteLine("Role:manager");
        }
    }
}
