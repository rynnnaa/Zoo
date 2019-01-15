﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Chinook : Fish
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
    }
}
