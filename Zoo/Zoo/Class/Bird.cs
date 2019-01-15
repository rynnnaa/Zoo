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

        abstract public void EatWorms();

        public virtual string CanFly()
        {
            return ("Bird's can fly");
        }
    }
}
