using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classshape
{
    class Circle : Shape
    {
        double pi = 3.14;
        float r1;
        public Circle(float r)
        {
            r1 = r;
        }


        public override void CalculateArea()
        {
           
            double a = 3.14 * r1* r1;

            Console.WriteLine("Area of Circle is " + a);

        }

    }
}
