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

        public override abstract void Swims();

        public string LaysEggs()
        {
            return "I lay eggs";
        }

        public virtual string DontCloseEyes()
        {
            return "Fish don't close their eyes";
    
        }
    }
}

