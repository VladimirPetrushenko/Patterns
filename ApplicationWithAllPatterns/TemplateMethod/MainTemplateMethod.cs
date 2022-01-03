using Strategy;
using System;
using TemplateMethod.Strategy;

namespace TemplateMethod
{
    public class MainTemplateMethod
    {
        public static void Make()
        {
            Console.WriteLine("Pattern TemplateMethod");
            var templateMethod = new TemplateMethodWithStrategy(new FirstExampleStrategy());
            templateMethod.Make();
        }
    }
}
