﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public class Guppy : Animal
    {
        public bool PetFish { get; set; }
        public override string ColdBlooded { get; set; }
        public override string Heterotrophy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IsTropical()
        {
            Console.WriteLine("Guppy's are a tropical fish");
        }

        public override bool Poops()
        {
            return base.Poops();
        }

        public override string EatsFood()
        {
            return base.EatsFood();
        }
    }
}
