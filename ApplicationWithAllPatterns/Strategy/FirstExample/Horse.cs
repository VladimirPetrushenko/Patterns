using System;

namespace Strategy.FirstExample
{
    class Horse : IMove
    {
        public void Move()
        {
            Console.WriteLine(" И-го-го");
        }
    }
}
