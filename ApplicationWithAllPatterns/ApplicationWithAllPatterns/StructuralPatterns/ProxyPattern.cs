using Proxy;
using TemplateMethod;

namespace ApplicationWithAllPatterns.StructuralPatterns
{
    internal class ProxyPattern
    {
        public static void MakeWithTemplateMethod()
        {
            FunctionalTemplateMethod.Make(MainProxy.Make);
        }
    }
}
