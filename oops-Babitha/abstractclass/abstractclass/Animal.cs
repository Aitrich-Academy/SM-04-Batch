﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
 public  abstract class Animal
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

    }
}
