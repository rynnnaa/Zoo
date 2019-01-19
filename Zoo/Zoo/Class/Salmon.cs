using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public abstract class Salmon : Fish, IHunt
    {
        public string Tasty { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy { get; set; }

        public override bool Swims()
        {
            return base.Swims();
        }

        public override bool Hunt()
        {
            return base.Hunt();
        }

    }
}
