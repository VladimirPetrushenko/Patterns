using AbstractFactory.Common;
using System;

namespace AbstractFactory
{
    public class MainAbstractFactory
    {
        public static void Make()
        {
            Console.WriteLine("Pattern Abstract factory\n");

            var factory = AbstractFactory.GetFactory(true);

            var ui = factory.CreateUI(TypeUI.Button);
            ui.Message();

            ui = factory.CreateUI(TypeUI.ButtonWithStyle);
            ui.Message();

            factory = AbstractFactory.GetFactory(false);

            ui = factory.CreateUI(TypeUI.NavPanel);
            ui.Message();

            ui = factory.CreateUI(TypeUI.ButtonWithStyle);
            ui.Message();
        }
    }
}
