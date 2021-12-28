using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizzaes
{
    internal class Cheese : Pizza
    {
        private readonly Pizza pizza;

        public Cheese(Pizza pizza) =>
            this.pizza = pizza;

        public override string Cook() => pizza.Cook() + "Cheese -> ";
    }
}
