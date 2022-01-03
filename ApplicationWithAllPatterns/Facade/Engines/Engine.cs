using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Engines
{
    internal class Engine
    {
        public void Start()
        {
            Console.WriteLine("Мотор завелся");
        }

        public void Boots()
        {
            Console.WriteLine("Машина ускоряется");
        }

        public void Going(int speed)
        {
            Console.WriteLine($"Машина разогналась и будет поддерживать скорость {speed}");
        }
    }
}
