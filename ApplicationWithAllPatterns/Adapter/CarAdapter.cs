using Adapter.Cars;

namespace Adapter
{
    class CarAdapter : IAdapter
    {
        private readonly Car car;

        public CarAdapter(Car car)
        {
            this.car = car;
        }

        public void Moving()
        {
            car.Start();
        }
    }
}
