namespace Visitor.Numbers_like_Interpretator_.WithVisiter
{
    //add new class
    class Calculator
    {
        private readonly Node expression;

        public Calculator(Node expression)
        {
            this.expression = expression;
        }

        public static int Calc(Node node)
        {
            if (node is Number n)
            {
                return n.Value;
            }
            else if (node is ArithmeticExpression a)
            {
                int left = Calc(a.Left);
                int right = Calc(a.Right);

                switch (a.Operation)
                {
                    case "+":
                        return left + right;
                    case "-":
                        return left - right;
                    case "*":
                        return left * right;
                    default:
                        return left / right;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return Calc(expression).ToString();
        }
    }
}
