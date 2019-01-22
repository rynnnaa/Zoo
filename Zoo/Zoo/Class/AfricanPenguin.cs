using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    class AfricanPenguin : Animal, ISwim
    {
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy { get; set; }

        public override void CanLive()
        {
            return;
        }

        public override void Poops()
        {
            return;
        }

        public bool Swim(ISwim swim)
        {
            return true;

        }
    }
}
