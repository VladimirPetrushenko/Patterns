using System;

namespace Adapter.Cars
{
    class BMV : Car
    {
        public override void Start()
        {
            Console.WriteLine("I am BMV. I started moving. My speed is 60");
        }
    }
}
