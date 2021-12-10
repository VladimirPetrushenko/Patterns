using System;
using TemplateMethod;
using Visitor.Animals.WithoutVisiter;
using Visitor.Animals.WithVisiter;
using Visitor.Numbers_like_Interpretator_.WithoutVisiter;
using Visitor.Numbers_like_Interpretator_.WithVisiter;

namespace ApplicationWithAllPatterns.BehaviorPatterns
{
    static class VisiterPatterns
    {
        public static void MakeWithTemplateMethod()
        {
            Console.WriteLine("Without visiter");
            FunctionalTemplateMethod.Make(Main.Make);

            Console.WriteLine("Visiter");
            FunctionalTemplateMethod.Make(MainWithVisiter.Make);

            Console.WriteLine("Without visiter");
            FunctionalTemplateMethod.Make(NumbersMain.Make);

            Console.WriteLine("Visiter");
            FunctionalTemplateMethod.Make(NumbersMainWithVisiter.Make);
        }
    }
}
