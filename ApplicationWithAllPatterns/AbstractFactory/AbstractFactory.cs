namespace AbstractFactory
{
    class AbstractFactory
    {
        public static IFactory GetFactory(bool IsAndroid)
        {
            if (IsAndroid)
            {
                return new AndroidFactory();
            }
            else 
            { 
                return new IOSFactory();
            }
        }
    }
}
