using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Sockeye : Fish
    {
        public string IsRed { get; set; }
        public override string ColdBlooded { get; set; }
        public bool GoodSushi()
        {
            return true;
        }

        public override string WarmBlooded { get; set; }

    }
}