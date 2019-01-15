﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Animal
    {
        public string WarmBlooded { get; set; }
        public string ColdBlooded { get; set; }
        public string Heterotrophy { get; set; }

        public bool EatsFood()
        {
            Console.WriteLine("I can eat food");
            return true;
        }

        public string LaysEggs()
        {
            return "I lay eggs"
        }

        public bool Hunt()
        {
            Console.WriteLine("I can hunt");
            return true;
        }

        public abstract void Swims();
        public abstract void Poops();
    }

}
