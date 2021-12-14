using AbstractFactory.Common;

namespace AbstractFactory
{
    public class MainAbstractFactory
    {
        public static void Make()
        {
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
