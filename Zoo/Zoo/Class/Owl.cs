using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Owl : Animal
    {
        public virtual bool HarryPotterBird { get; set; }

        public void MakesSounds()
        {
            Console.WriteLine("Owls make Hoo sounds");
        }

        public override void Swims()
        {
            Console.WriteLine("Owl's can swim");
        }

        public override void Poops()
        {
            Console.WriteLine("Owl's can poop");
        }

        public virtual string CanFly()
        {
            return "Thank you everyone for this!";
        }
    }
}
