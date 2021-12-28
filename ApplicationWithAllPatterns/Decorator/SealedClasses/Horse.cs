using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.SealedClasses
{
    sealed class Horse : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Бегу");
        }
    }
}
