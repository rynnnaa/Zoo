using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Chinook : Fish, IHunt
    {
        public bool IsPink { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy { get; set; }

        public bool IsKingSalmon()
        {
            return true;
        }

        public override bool Swims()
        {
            return base.Swims();
        }

        public override void Poops()
        {
            return;
        }


        public override void CanLive()
        {
            return;
        }

        public override bool Hunt()
        {
            return base.Hunt();
        }

    }
}
