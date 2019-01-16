using System;
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
            Console.WriteLine($"Owls are in the Harry Potter movie {owl.HarryPotterBird}");
            Console.WriteLine($"Owls have wings {owl.Wings}");

            Sockeye sockeye = new Sockeye();
            Console.WriteLine("============SOCKEYE============");
            Console.WriteLine(sockeye.EatsFood());
            Console.WriteLine($"Sockeyes have Gills {sockeye.HasGills}");
            Console.WriteLine($"Sockeye are { sockeye.Scaley} ");

            Chinook chinook = new Chinook();
            Console.WriteLine("============CHINOOK============");
            Console.WriteLine(chinook.EatsFood());
            Console.WriteLine($"Chinook fish are {chinook.Heterotrophy}");
            Console.WriteLine($"Chinook fish have a tail { chinook.HasTail }");




        }
    }
}
