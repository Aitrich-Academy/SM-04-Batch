using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_vehicleshowroom
{

  public  class Car:Vehicle
    {
         int d = 4;

        public Car(string b, string m, int p )
        {
            Brand = b;
            Model = m;
            Price = p;
         
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("No:of dooors:" + d);
        }

    }
}
