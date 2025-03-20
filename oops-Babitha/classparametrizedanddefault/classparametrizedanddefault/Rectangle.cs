using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classparametrizedanddefault
{
   public  class Rectangle
    {
        public int length;
        public int breadth;
        public Rectangle(int l,int b)
        {
            length = l;
            breadth = b;
        }
       //int CalculateArea()
       // { 
       //     return length * breadth;
       // }
       // public void Display()
       // {
       //     Console.WriteLine("Length: " + length);
       //     Console.WriteLine("Breadth: " + breadth);
       //     Console.WriteLine("Area: " + CalculateArea());
       // }
       public void calculateArea()
        {
            Console.WriteLine("Area of rectangle is: " + (length * breadth));
        }
        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Breadth: " + breadth);
            calculateArea();
        }
    }
}
