using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Guppy : Animal, ISwim
    {
        public bool PetFish { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy { get; set; }

        public void IsTropical()
        {
            Console.WriteLine("Guppy's are a tropical fish");
        }

        public override void Poops()
        {
            return;
        }

        public override string EatsFood()
        {
            return base.EatsFood();
        }

        public override void CanLive()
        {
            return;

        }
        public bool Swim(ISwim swim)
        {
            return true;

        }
    }
}
