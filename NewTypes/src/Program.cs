using System;
using Pets;
using System.Collections.Generic;

namespace NewTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPet> pets = new List<IPet>
            {
                new Dog(),
                new Cat(),
                new Bird(),
                new Lion()
            };

            foreach (var pet in pets)
            {
                Console.WriteLine(pet.TalkToOwner());
            }
        }
    }
}
