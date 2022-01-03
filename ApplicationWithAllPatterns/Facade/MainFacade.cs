using Facade.Engines;
using System;

namespace Facade
{
    public class MainFacade
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Facade\n");

            Car car = new Car();
            CarFacad facad = new CarFacad(car);

            facad.TurnOn();
            facad.CruizControle();
            facad.TurnOff();
        }
    }
}
