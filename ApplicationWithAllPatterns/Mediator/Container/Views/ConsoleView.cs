using Mediator.Container.Interfaces;
using System;

namespace Mediator.Container.Views
{
    class ConsoleView : IView
    {
        public string X 
        { 
            get
            {
                Console.WriteLine("Enter the number x:");
                return Console.ReadLine();
            }
        }

        public string Y 
        {
            get
            {
                Console.WriteLine("Enter the number y:");
                return Console.ReadLine();
            }
        }

        public string Result { set => Console.WriteLine(value); }
    }
}
