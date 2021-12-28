using System;

namespace Decorator.SealedClasses
{
    internal class RuningHorseDecorator : Animal
    {
        protected Horse Horse { get; set; }

        public RuningHorseDecorator()
        {
            Horse = new Horse();
        }

        public override void Move()
        {
            Console.WriteLine("Сначала я осматриваю ноги, а затем");
            Horse.Move();
        }

        public void NewFuture()
        {
            Console.WriteLine("Прыгаю как угарелая");
            Horse.Move();
            Console.WriteLine("Опять прыгаю");
        }
    }
}
