using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Bird
    {
        public string Feathers { get; set; }
        abstract public bool Wings { get; set; }
        public string Beak { get; set; }

        public void EatWorms()
        {
            Console.WriteLine("Birds eat Worms");
        }

        public virtual void CanFly()
        {
            Console.WriteLine("Birds can fly");
        }

    }
}
