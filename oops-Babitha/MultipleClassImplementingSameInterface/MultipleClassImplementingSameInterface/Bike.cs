using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassImplementingSameInterface
{
   public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine("bike engine stopped");
        }
    }
}
