using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Engines
{
    internal class Battery
    {
        public void GivePower()
        {
            Console.WriteLine("Подать напряжение");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Убрать напряжение");
        }

        public void TakePower()
        {
            Console.WriteLine("Батарека заряжается");
        }
    }
}
