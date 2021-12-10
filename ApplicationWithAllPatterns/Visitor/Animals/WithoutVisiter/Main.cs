using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Animals.WithoutVisiter
{
    public class Main
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
