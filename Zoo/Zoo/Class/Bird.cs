using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Bird
    {
        public string Feathers { get; set; }
        public bool Wings { get; set; }
        public string Beak { get; set; }

        string CanFly()
        {
            return ("Bird's can fly");
        }
    }
}
