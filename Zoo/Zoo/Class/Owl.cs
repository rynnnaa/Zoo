using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Owl : Bird
    {
        public virtual bool HarryPotterBird { get; set; }
        public override bool Wings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            