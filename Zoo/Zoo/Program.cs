﻿using System;
using Zoo.Class;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Salmon salmon = new Salmon();
            Console.WriteLine("============SALMON============");
            Console.WriteLine(salmon.EatsFood());
            Console.WriteLine($"Salmon '{salmon.Hunt()}");
            Console.WriteLine($"Salmin '{ salmon.Swims() }");
        }
    }
}
