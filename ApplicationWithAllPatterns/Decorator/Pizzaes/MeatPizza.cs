using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Pizzaes
{
    internal class MeatPizza : Pizza
    {
        private readonly Pizza pizza;

        public MeatPizza(Pizza pizza) =>
            this.pizza = pizza;

        public override string Cook() => pizza.Cook() + "Meat pizza -> ";
    }
}
