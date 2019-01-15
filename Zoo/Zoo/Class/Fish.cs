using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Fish : Animal
    {
        public bool Scaley { get; set; }
        public bool HasTail { get; set; }
        public bool HasGills { get; set; }

        public bool Swims()
        { 
        return true;
        }

        public string LaysEggs()
        {
            return "I lay eggs";
        }
    }
}

