using Decorator.Cars;
using Decorator.Pizzaes;
using Decorator.SealedClasses;
using System;

namespace Decorator
{
    public class MainDecorator
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Decorator\n");

            var pizza = new Pizza();
            var meatPizza = new MeatPizza(pizza);
            var cheeseMeatPizza = new Cheese(meatPizza);

            Console.WriteLine(cheeseMeatPizza.Cook());

            var a4 = new A4();
            var a4WithMatrixLed = new AudiMatrixLed(a4);
            var a4WithMatrixLedAndBlueLight = new BlueLights(a4WithMatrixLed);

            Console.WriteLine(a4WithMatrixLedAndBlueLight.Complectation());

            var horse = new RuningHorseDecorator();
            horse.Move();
            horse.NewFuture();
        }
    }
}
