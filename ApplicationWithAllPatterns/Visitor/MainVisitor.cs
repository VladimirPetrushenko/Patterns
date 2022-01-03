using System;
using Visitor.Animals.WithoutVisiter;
using Visitor.Animals.WithVisiter;
using Visitor.Numbers_like_Interpretator_.WithoutVisiter;
using Visitor.Numbers_like_Interpretator_.WithVisiter;

namespace Visitor
{
    public class MainVisitor
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Visitor");
            Console.WriteLine();

            Console.WriteLine("Without visiter");
            Main.Make();

            Console.WriteLine("Visiter");
            MainWithVisiter.Make();

            Console.WriteLine("Without visiter");
            NumbersMain.Make();

            Console.WriteLine("Visiter");
            NumbersMainWithVisiter.Make();
        }
    }
}
