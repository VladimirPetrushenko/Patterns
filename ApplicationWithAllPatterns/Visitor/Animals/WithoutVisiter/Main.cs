using System;
using System.Collections.Generic;

namespace Visitor.Animals.WithoutVisiter
{
    class Main
    {
        public static void Make()
        {
            var animals = new List<Animal>
            {
                new Bird(),
                new Cat(),
                new Dog(),
            };

            foreach (var animal in animals)
            {
                animal.Voice();
            }
            Console.WriteLine();

            //new
            foreach (var animal in animals)
            {
                animal.Eat();
            }
            Console.WriteLine();

            //new
            foreach (var animal in animals)
            {
                animal.Move();
            }
            Console.WriteLine();

            //new
            foreach (var animal in animals)
            {
                animal.Stand();
            }
        }
    }
}
