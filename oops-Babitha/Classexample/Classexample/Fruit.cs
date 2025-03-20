using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample
{
    public class Fruit
    {
      public  string name;
        public string color;
      public    Fruit(string name1,string col)
        {
            name = name1;
            color = col;
        }
        public void display()
        {
            Console.WriteLine("Name of the fruit is " + name);
            Console.WriteLine("Color of the fruit is " + color);

        }

    }
}
