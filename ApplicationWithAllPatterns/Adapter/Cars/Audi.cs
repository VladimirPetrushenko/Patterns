using System;

namespace Adapter.Cars
{
    class Audi : Car
    {
        public override void Start()
        {
            Console.WriteLine("I am Audi. I started moving. My speed is 120");
        }
    }
}
