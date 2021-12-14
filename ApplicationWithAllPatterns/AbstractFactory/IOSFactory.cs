using AbstractFactory.Common;
using AbstractFactory.IOS;

namespace AbstractFactory
{
    class IOSFactory : IFactory
    {
        public IUI CreateUI(TypeUI uI)
        {
            return uI switch
            {
                TypeUI.Button => new IOSButton(),
                TypeUI.ButtonWithStyle => new IOSStyleButton(),
                TypeUI.NavPanel => new IOSNavigation(),
                _ => new UnknownUI(),
            };
        }
    }
}
