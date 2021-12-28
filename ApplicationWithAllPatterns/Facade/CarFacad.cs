using Facade.Engines;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    internal class CarFacad
    {
        private readonly Car car;

        public CarFacad(Car car)
        {
            this.car = car;
        }

        public void TurnOn()
        {
            car.key.Enter();
            car.battery.GivePower();
            car.engine.Start();
            car.battery.TakePower();
        }

        public void TurnOff()
        {
            car.key.Exit();
            car.battery.SwitchOff();
        }

        public void CruizControle()
        {
            Console.WriteLine("Введите скорость до которой нужно разогнаться");
            var speed = int.Parse(Console.ReadLine());
            car.engine.Boots();
            car.engine.Going(speed);
        }
    }
}
