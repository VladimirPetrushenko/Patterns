using Strategy.FirstExample;
using System;

namespace Strategy
{
    public class FirstExampleStrategy : IStrategy
    {
        public void Make()
        {
            Console.WriteLine("start first strategy");
            IMove mover = new Car();
            mover.Move();

            mover = new Horse();
            mover.Move();

            Console.WriteLine("End");
        }
    }
}
