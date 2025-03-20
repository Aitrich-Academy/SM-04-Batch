using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassImplementingSameInterface
{
    // Use an interface to define a contract and implement it in multiple classes.
    interface IVehicle
    {
        public void StartEngine();
        public void StopEngine();
    }
}
