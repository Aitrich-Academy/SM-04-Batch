using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classvegetables
{
   public class Vegetable
    {
        public string name;
        public string color;
        public string type;
        public Vegetable(string name1, string color1, string type1)
        {
            name = name1;
            color = color1;
            type = type1;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("color:"+ color);
            Console.WriteLine("type:" + type);
            Console.WriteLine(" ");

        }
    }
}
