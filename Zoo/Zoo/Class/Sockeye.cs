using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Sockeye : Fish
    {
        public string IsRed { get; set; }

        public bool GoodSushi()
        {
            return true;
        }

        public override void Poops()
        {
            Console.WriteLine("Sockeye Poop");
        }

        public override void Swims()
        {
            Console.WriteLine("Sockeye Swim");
        }

        public override string ColdBlooded { get; set; }
    }
}