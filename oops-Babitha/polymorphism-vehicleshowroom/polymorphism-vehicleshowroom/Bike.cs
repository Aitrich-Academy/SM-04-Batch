using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_vehicleshowroom
{
   public class Bike:Vehicle
    {
        Boolean HasGear=true;
        public Bike(string b, string m, int p)
        
        {
            Brand = b;
            Model = m;
            Price = p;
         
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            if (HasGear)
            {

                Console.WriteLine("Has Gear:yes");
                

            }
           
        }
    }
}
