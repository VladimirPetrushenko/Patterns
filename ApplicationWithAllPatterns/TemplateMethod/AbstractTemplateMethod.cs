using System;

namespace TemplateMethod
{
    public abstract class AbstractTemplateMethod
    {
        private void Start() => Console.WriteLine("--------Start opperation---------");
        private void End() => Console.WriteLine("---------------End---------------");
        protected abstract void ToDoSomething();
        
        public void Make()
        {
            ToDoSomething();
            Console.WriteLine();
        }
    }
}
