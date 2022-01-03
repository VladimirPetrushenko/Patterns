using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizzaes
{
    internal class ChikenPizza : Pizza
    {
        private readonly Pizza pizza;

        public ChikenPizza(Pizza pizza) =>
            this.pizza = pizza;

        public override string Cook() => pizza.Cook() + "Chiken pizza -> ";
    }
}
