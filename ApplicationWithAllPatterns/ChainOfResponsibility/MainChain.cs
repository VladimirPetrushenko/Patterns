using ChainOfResponsibility.Chains;
using System;

namespace ChainOfResponsibility
{
    public class MainChain
    {
        public void Make()
        {
            Console.WriteLine("Pattern Chain of responsibility");
            PrintResult print = new PrintResult(Start);
            MultFourIfResultMoreThan20 mult = new MultFourIfResultMoreThan20(print.Make);
            AddTwoToResult add = new AddTwoToResult(mult.Make);
            PrintResult start = new PrintResult(add.Make);

            start.Make(19);
        }

        public void Start(int context)
        {
            Console.WriteLine("\nI am in Start");
            Console.WriteLine("Context " + context);

            Console.WriteLine("Действия которые будут выполняться в обратном порядке");
        }
    }
}
