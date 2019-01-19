using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public class Sockeye : Fish
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
    }

}