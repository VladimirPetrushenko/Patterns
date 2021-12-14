using System;

namespace AbstractFactory.IOS
{
    class IOSButton : IOSUI
    {
        public override void Message()
        {
            Console.WriteLine("Не стилизованная кнопка в IOS");
        }
    }
}
