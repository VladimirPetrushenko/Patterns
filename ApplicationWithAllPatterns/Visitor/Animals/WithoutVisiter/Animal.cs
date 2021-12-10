namespace Visitor.Animals.WithoutVisiter
{
    abstract class Animal
    {
        public abstract void Voice();

        //if we want to add some methods. Look how many changes we need to do.
        //All chenges will accompanied by comments

        //new methods
        public abstract void Eat();

        //new methods
        public abstract void Move();

        //new methods
        public abstract void Stand();
    }
}
