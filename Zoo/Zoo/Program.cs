﻿using System;
using Zoo.Class;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Guppy guppy = new Guppy();
            Console.WriteLine("============GUPPY============");
            Console.WriteLine(guppy.EatsFood());
            Console.WriteLine($"Guppies are HUGE fish {guppy.PetFish}");
            Console.WriteLine($"Guppies are cold blooded Animals {guppy.ColdBlooded}");

            Owl owl = new Owl();
            Console.WriteLine("============OWL============");
            Console.WriteLine($"Owls have feathers {owl.Feathers}");
            Console.WriteLine($"Owls can fly {owl.CanFly()}");
            Console.WriteLine($"Owls have wings {owl.Wings}");

            Sockeye sockeye = new Sockeye();
            Console.WriteLine("============SOCKEYE============");
            Console.WriteLine(sockeye.EatsFood());
            Console.WriteLine($"Sockeyes lay eggs {sockeye.LaysEggs()}");
            Console.WriteLine($"Sockeye are { sockeye.Scaley} ");

            Chinook chinook = new Chinook();
            Console.WriteLine("============CHINOOK============");
            Console.WriteLine(chinook.EatsFood());
            Console.WriteLine($"Chinook fish can ingest food {chinook.Heterotrophy}");
            Console.WriteLine($"Chinook fish have a tail { chinook.HasTail }");




        }
    }
}
