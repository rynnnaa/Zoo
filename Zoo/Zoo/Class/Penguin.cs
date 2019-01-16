using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    abstract class Penguin : Bird
    {
        public bool BlackAndWhite { get; set; }
        public override bool Wings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EatFish()
        {
            Console.WriteLine("Penguins Eat Fish");
        }

        public bool EatKrill()
        {
            Console.WriteLine("Penguins eat Krill");
            return true;
        }
    }
}
