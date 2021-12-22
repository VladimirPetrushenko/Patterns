using System;

namespace FactoryMethod.FactoryMethodWithFactory
{
    class UnknownCar : Car
    {
        public override void Make()
        {
            Console.WriteLine("Sorry, you can't go by that car because it is unknown car");
        }
    }
}
