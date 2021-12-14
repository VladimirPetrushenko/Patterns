using AbstractFactory.Common;

namespace AbstractFactory
{
    interface IFactory
    {
        IUI CreateUI(TypeUI uI);
    }
}
