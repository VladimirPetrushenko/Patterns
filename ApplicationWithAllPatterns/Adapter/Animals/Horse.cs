using System;

namespace Adapter.Animals
{
    class Horse : Animal
    {
        public override void Move(int distance)
        {
            Console.WriteLine($"I am a horse.I started moving. I need to go {distance}");
        }
    }
}
