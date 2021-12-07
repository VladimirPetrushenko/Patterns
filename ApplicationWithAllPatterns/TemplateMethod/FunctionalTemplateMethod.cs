using System;

namespace TemplateMethod
{
    public static class FunctionalTemplateMethod
    {
        private static void Start() => Console.WriteLine("--------Start opperation---------");
        private static void End() => Console.WriteLine("---------------End---------------");
        public static void Make(Action action)
        {
            Start();
            action();
            End();
            Console.WriteLine();
        }
    }
}
