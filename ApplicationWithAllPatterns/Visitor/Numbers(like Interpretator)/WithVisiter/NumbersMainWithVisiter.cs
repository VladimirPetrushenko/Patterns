using System;

namespace Visitor.Numbers_like_Interpretator_.WithVisiter
{
    class NumbersMainWithVisiter
    {
        public static void Make()
        {
            Number a = new Number { Value = 1 };
            Number b = new Number { Value = 2 };
            Number c = new Number { Value = 3 };
            Number d = new Number { Value = 10 };
            Number f = new Number { Value = 2 };

            ArithmeticExpression add = new ArithmeticExpression { Left = a, Operation = "+", Right = b };
            ArithmeticExpression mult = new ArithmeticExpression { Left = add, Operation = "*", Right = c };

            ArithmeticExpression div = new ArithmeticExpression { Left = d, Operation = "/", Right = f };
            ArithmeticExpression sub = new ArithmeticExpression { Left = mult, Operation = "-", Right = div };

            Console.WriteLine($"{sub} = {new Calculator(sub)}");
        }
    }
}
