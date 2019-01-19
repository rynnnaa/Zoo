using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    public class Owl : Bird
    {
        public virtual bool HarryPotterBird { get; set; }
        public override bool Wings { get; set; }

        public void MakesSounds()
        {
            Console.WriteLine("Owls make Hoo sounds");
        }

        public override bool CanFly()
        {
            return true;
        }


    }
}
            