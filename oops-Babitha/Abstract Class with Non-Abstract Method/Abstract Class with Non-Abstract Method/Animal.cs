using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_with_Non_Abstract_Method
{
     public abstract class Animal
    {
        public abstract void MakeSound();
        public void sleeper() {
            Console.WriteLine("animal is sleeping");
        }
    }
}
