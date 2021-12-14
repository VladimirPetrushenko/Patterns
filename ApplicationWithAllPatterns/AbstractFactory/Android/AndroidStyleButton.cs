using System;

namespace AbstractFactory.Android
{
    class AndroidStyleButton : AndroidButton
    {
        public override void Message()
        {
            Console.WriteLine("Стилизованная кнопка");
        }
    }
}
