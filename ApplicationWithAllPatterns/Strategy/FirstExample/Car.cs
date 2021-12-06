using System;

namespace Strategy.FirstExample
{
    class Car : IMove
    {
        public void Move()
        {
            Console.WriteLine(" Трын дын дын");
        }
    }
}
