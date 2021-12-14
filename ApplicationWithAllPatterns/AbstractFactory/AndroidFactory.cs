using AbstractFactory.Android;
using AbstractFactory.Common;

namespace AbstractFactory
{
    class AndroidFactory : IFactory
    {
        public IUI CreateUI(TypeUI uI)
        {
            return uI switch
            {
                TypeUI.Button => new AndroidButton(),
                TypeUI.ButtonWithStyle => new AndroidStyleButton(),
                TypeUI.NavPanel => new AndroidNavigation(),
                _ => new UnknownUI(),
            };
        }
    }
}
