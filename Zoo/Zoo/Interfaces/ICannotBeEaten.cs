using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ICannotBeEaten
    {

        bool WillKillYou { get; set; }
        string JustGross { get; set; }


        bool Food(ICanBeEaten salmon);
    }
}
