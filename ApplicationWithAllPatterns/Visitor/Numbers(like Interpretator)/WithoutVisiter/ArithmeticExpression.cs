namespace Visitor.Numbers_like_Interpretator_.WithoutVisiter
{
    class ArithmeticExpression : Node
    {
        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public override string ToString() => $"({Left} {Operation} {Right})";

        //add new method
        public static void Calc(Node node, ref int res)
        {
            if(node is Number n) 
            { 
                res = n.Value; 
            }
            else if(node is ArithmeticExpression a) 
            {
                int left = 0;
                Calc(a.Left, ref left);
                int right = 0;
                Calc(a.Right, ref right);

                switch (a.Operation)
                {
                    case "+":
                        res = left + right; 
                        break;
                    case "-":
                        res = left - right;
                        break;
                    case "*":
                        res = left * right;
                        break;
                    case "/":
                        res = left / right;
                        break;
                }
            }

        }
    }
}
