using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classcar
{
   public class Car
    {
        public string model;
        public string color;
        public int year;
        public Car(string m1, string c1, int y1)
        {
            model = m1;
            color = c1;
            year = y1;
        }
        public void display()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
        }
    }
}
