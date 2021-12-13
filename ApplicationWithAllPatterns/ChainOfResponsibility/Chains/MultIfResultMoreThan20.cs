using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Chains
{
    class MultFourIfResultMoreThan20 : Handler
    {
        public MultFourIfResultMoreThan20(Chain next) : base(next)
        {
        }

        public override void Make(int context)
        {
            Console.WriteLine("\nI am in MultFourIfResultMoreThan20");
            if (context > 20)
            {
                context *= 4;
            }
            else
            {
                Console.WriteLine("Context is less than 20");
            }

            _next(context);
        }
    }
}
