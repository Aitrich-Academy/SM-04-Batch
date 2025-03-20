using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Interface_Implementation
{
 public   class Dog: IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
