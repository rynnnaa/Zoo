using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Sockeye : Fish, ISwim, IHunt
    {
        public string IsRed { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy{ get; set; }

        public override void CanLive()
        {
            throw new NotImplementedException();
        }

        public bool GoodSushi()
        {
            return true;
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