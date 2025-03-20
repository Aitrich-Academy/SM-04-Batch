using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classconstructor
{
   public class Animal

   {
        public string name;
        public string color;
        public int legs;
        public Animal( string n,string col,int l)
        {
            name = n;
            color = col;
            legs = l;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Legs: " + legs);
        }
    }
}
