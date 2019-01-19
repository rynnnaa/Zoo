using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ISwim
    {

        bool Swim();
        bool Swim(ISwim swim);
    }
}
