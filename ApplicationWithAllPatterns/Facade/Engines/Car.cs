using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Engines
{
    internal class Car
    {
        public readonly Battery battery;
        public readonly Engine engine;
        public readonly Key key;
        
        public Car()
        {
            battery = new Battery();
            engine = new Engine();
            key = new Key();
        }
    }
}
