namespace Visitor.Numbers_like_Interpretator_.WithoutVisiter
{
    class Number : Node
    {
        public int Value { get; set; }
        public override string ToString() => $"{Value}";
    }
}
