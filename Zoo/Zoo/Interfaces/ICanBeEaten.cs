using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface ICanBeEaten
    {

        bool RarelyEaten { get; set; }
        bool OftenEaten { get; set; }

        void EatFood();
    }
}