using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Chinook : Fish
    {
        public bool IsPink { get; set; }

        public override void Poops()
        {
           Console.WriteLine("Chinnok Poop");
        }
    }

}
