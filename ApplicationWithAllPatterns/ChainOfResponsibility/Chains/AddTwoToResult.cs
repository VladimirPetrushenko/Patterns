using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Chains
{
    class AddTwoToResult : Handler
    {
        public AddTwoToResult(Chain next)
            :base(next) 
        {
        }

        public override void Make(int context)
        {
            Console.WriteLine("\nI am in AddTwoToResult");
            context += 2;
            _next(context);
        }
    }
}
