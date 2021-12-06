using Strategy.FirstExample;

namespace Strategy
{
    public class FirstExampleStrategy : IStrategy
    {
        public void Make()
        {
            IMove mover = new Car();
            mover.Move();

            mover = new Horse();
            mover.Move();
        }
    }
}
