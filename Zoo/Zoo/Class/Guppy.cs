using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Guppy : Fish
    {
        public bool Colorful { get; set; }
        public virtual bool PetFish { get; set; }

        public void IsTropical()
        {
            Console.WriteLine("Guppy's are a tropical fish");
        }

        public override void Swims()
        {
            Console.WriteLine("Guppies can swim");
        }
     
    }
}
