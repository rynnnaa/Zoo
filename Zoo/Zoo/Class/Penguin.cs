using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Penguin : Bird
    {
        public bool BlackAndWhite { get; set; }

        public void EatFish()
        {
            Console.WriteLine("Penguins Eat Fish");
        }

        public virtual bool EatKrill()
        {
            Console.WriteLine("");
            return true;
        }
    }
}
