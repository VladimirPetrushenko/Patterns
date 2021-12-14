using System;

namespace AbstractFactory.Android
{
    class AndroidButton : AndroidUI
    {
        public override void Message()
        {
            Console.WriteLine("Не стилизованная кнопка");
        }
    }
}
