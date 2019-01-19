using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Sockeye : Fish, ISwim
    {
        public string IsRed { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy{ get; set; }

        public bool GoodSushi()
        {
            return true;
        }


        public override bool Swims()
        {
            return base.Swims();
        }

        bool ISwim.Swim(ISwim swim)
        {
            Console.WriteLine("I can swim");
            return true;
        }
    }

}