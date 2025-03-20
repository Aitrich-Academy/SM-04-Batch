using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_vehicleshowroom
{
  public  class Vehicle
    {
        public string Brand, Model;
        public int Price;
        
        //public Vehicle(string b,string m, int p)
        //{
        //    Brand = b;
        //    Model = m;
        //    Price = p;
           

        //}    
      public virtual void  DisplayInfo()
        {
            Console.WriteLine("Vehicles details:");
            Console.WriteLine("Brand:"+Brand);
            Console.WriteLine("Model:"+Model);
            Console.WriteLine("Price:"+Price);
           


        }

    }
}
