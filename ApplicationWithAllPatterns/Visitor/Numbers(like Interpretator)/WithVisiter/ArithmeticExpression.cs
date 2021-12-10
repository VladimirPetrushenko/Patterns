namespace Visitor.Numbers_like_Interpretator_.WithVisiter
{
    class ArithmeticExpression : Node
    {
        public string Operation { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public override string ToString() => $"({Left} {Operation} {Right})";

        
    }
}
