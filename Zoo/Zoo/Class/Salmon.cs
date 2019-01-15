using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Salmon : Fish
    {
        public string Tasty { get; set; }

        public override void Swims()
        {
            Console.WriteLine("Salmon can swim");
        }
    }
}
