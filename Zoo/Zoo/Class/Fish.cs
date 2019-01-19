using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public abstract class Fish : Animal
    {
        public bool Scaley { get; set; }
        public bool HasTail { get; set; }
        public bool HasGills { get; set; }

        virtual public bool Swims()
        { 
        return true;
        }

        public string LaysEggs()
        {
            return "I lay eggs";
        }
    }
}

