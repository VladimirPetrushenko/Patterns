using System;

namespace AbstractFactory.Common
{
    class UnknownUI : IUI
    {
        public void Message()
        {
            Console.WriteLine("This is unknown UI");
        }
    }
}
