using FactoryMethod.FactoryMethodWithFactory;
using System;

namespace FactoryMethod
{
    public class MainFactoryMethod
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Factory method\n");

            var car = CarFactory.Create(TypeCar.CommonCar);
            car.Make();

            car = CarFactory.Create(TypeCar.TuningCar);
            car.Make();

            var time = TimeTick.FromMinutes(30);
            Console.WriteLine(time);

            time = new TimeTick(30);
            Console.WriteLine(time);
        }
    }
}
