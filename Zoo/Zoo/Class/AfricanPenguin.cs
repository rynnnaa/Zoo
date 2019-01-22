using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class AfricanPenguin : Bird, ISwim
    {

        public override bool Wings { get; set; }


        public bool Swim(ISwim swim)
        {
            return true;

        }

        public override bool CanFly()
        {
            return base.CanFly();
        }
    }
}
