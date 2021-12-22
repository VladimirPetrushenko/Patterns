using FactoryMethod.FactoryMethodWithFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class MainFactoryMethod
    {
        public static void Make()
        {
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
