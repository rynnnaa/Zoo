using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Class
{
    class Salmon : Animal
    {
        public string Tasty { get; set; }
        public override string ColdBlooded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Heterotrophy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Poops()
        {
            Console.WriteLine("Salmon poop");
        }

        public override void Swims()
        {
            Console.WriteLine("Salmon can swim");
        }

        public string DontCloseEyes()
        {
            return "";
        }

    }
}
