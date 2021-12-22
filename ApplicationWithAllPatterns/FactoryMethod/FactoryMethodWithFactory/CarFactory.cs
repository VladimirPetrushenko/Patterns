namespace FactoryMethod.FactoryMethodWithFactory
{
    class CarFactory
    {
        public static Car Create(TypeCar car)
        {
            switch (car)
            {
                case TypeCar.CommonCar:
                    return new Car();
                case TypeCar.TuningCar:
                    return new TuningCar();
                default:
                    return new UnknownCar();
            }
        }
    }
}
