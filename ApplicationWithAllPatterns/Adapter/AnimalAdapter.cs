using Adapter.Animals;

namespace Adapter
{
    class AnimalAdapter : IAdapter
    {
        private readonly Animal animal;

        public AnimalAdapter(Animal animal)
        {
            this.animal = animal;
        }

        public void Moving()
        {
            animal.Move(20);
        }
    }
}
