using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassImplementingSameInterface
{
    class Car: IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }
        public void StopEngine()
        {
            Console.WriteLine("car engine stopped");
        }
    }
}
