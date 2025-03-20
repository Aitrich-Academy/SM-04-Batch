using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_Non_Abstract_Method
{
   public class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("bark");
        }
    }
}
