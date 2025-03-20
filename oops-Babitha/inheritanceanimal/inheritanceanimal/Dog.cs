using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceanimal
{
   public class Dog: Animal
    {
       
        public void bark()
        {
            Console.WriteLine(name+" is Barking...");
        }
    }
}
