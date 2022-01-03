using Adapter.Animals;
using Adapter.Cars;
using System.Collections.Generic;

namespace Adapter
{
    public class MainAdapter
    {
        public static void Make()
        {
            var AdapterList = new List<IAdapter>()
            {
                new CarAdapter(new BMV()),
                new AnimalAdapter(new Horse()),
                new CarAdapter(new Audi()),
                new CarAdapter(new BMV()),
            };

            foreach(var adapter in AdapterList)
            {
                adapter.Moving();
            }
        }
    }
}
