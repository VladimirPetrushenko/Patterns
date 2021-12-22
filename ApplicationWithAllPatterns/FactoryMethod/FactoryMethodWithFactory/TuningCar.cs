using System;

namespace FactoryMethod.FactoryMethodWithFactory
{
    class TuningCar: Car
    {
        public override void Make()
        {
            Console.WriteLine("You drive by tuning car");
        }
    }
}
