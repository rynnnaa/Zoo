﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Salmon : Fish
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
