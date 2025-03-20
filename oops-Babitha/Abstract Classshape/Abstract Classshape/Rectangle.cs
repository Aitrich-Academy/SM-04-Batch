using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classshape
{
    class Rectangle:Shape
    {
        int width;
        int length;

      public  Rectangle( int l, int b)
        {
            length = l;
            width = b;
         
        }
        public override void CalculateArea()
        {

            int a = length * width;
            Console.WriteLine("Area of rectangle is: " + a);

        }
    }
    
}
