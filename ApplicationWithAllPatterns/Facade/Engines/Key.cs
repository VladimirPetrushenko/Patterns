using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Engines
{
    internal class Key
    {
        public void Enter()
        {
            Console.WriteLine("Вставить ключ");
            Console.WriteLine("Повернуть ключ на 90 градусов");
        }

        public void Exit()
        {
            Console.WriteLine("Повернуть ключ на 90 градусов");
            Console.WriteLine("Достать ключ");
        }
    }
}
