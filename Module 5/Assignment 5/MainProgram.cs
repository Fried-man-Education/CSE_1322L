using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment5
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            LinkedList<BirdSpecies> list = new LinkedList<BirdSpecies>();
            Console.WriteLine("Entered the black chin at: " + list.Add(new BirdSpecies("Black-chinned hummingbird")));
            Console.WriteLine("Entered the African swallow at: " + list.Add(new BirdSpecies("West African Swallow")));
            Console.WriteLine("Entered the second black chin at: " + list.Add(new BirdSpecies("Black-chinned hummingbird")));
            Console.WriteLine("Entered the African swallow at: " + list.Add(new BirdSpecies("West African Swallow")));
            Console.WriteLine("Count of black chin is: " + list.GetCount(new BirdSpecies("Black-chinned hummingbird")));
            Console.WriteLine(list.GetReport());
        }
    }
}
