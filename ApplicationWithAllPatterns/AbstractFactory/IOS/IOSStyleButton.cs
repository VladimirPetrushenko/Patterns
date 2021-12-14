using System;

namespace AbstractFactory.IOS
{
    class IOSStyleButton : IOSButton
    {
        public override void Message()
        {
            Console.WriteLine("Стилизованная кнопка в IOS");
        }
    }
}
