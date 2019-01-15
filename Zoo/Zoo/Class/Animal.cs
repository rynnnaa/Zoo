using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Animal
    {
        public virtual string WarmBlooded { get; set; }
        public abstract string ColdBlooded { get; set; }
        public abstract string Heterotrophy { get; set; }

        public bool EatsFood()
        {
            Console.WriteLine("I can eat food");
            return true;
        }

        public virtual bool Hunt()
        {
            Console.WriteLine("I can hunt");
            return true;
        }

        public virtual bool Poops()
        {
            return true;

        }
    }
}
