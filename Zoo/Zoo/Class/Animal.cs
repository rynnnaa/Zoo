﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public abstract class Animal
    {
        public virtual string WarmBlooded { get; set; }
        public abstract string ColdBlooded { get; set; }
        public abstract string Heterotrophy { get; set; }
        public virtual string CanMove { get; set; }


        public virtual string EatsFood()
        {
            return "I can eat food";
        }

        public virtual bool Hunt()
        {
            Console.WriteLine("I can hunt");
            return true;
        }

        public abstract void Poops();

        public abstract void CanLive();

    }
}
