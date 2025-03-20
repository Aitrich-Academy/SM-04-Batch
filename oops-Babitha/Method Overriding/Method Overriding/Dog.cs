using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    class Dog: Mamal
    {
        string p1;
        public Dog(string p)
        {
            p1 = p;
        }
        public  void MakeSound()
        {
            Console.WriteLine(p1);

            Console.WriteLine("Dog barks.");
        }
    }
}
