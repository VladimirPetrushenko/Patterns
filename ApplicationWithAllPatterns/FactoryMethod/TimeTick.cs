namespace FactoryMethod
{
    class TimeTick
    {
        public double Ticks { get; set; }

        public TimeTick(double ticks)
        {
            Ticks = ticks; 
        }

        //Factory methods
        public static TimeTick FromMilliseconds(double mSec)
        {
            return new TimeTick(mSec * 16);
        }

        public static TimeTick FromSeconds(double sec)
        {
            return FromMilliseconds(sec * 1000);
        }

        public static TimeTick FromMinutes(double min)
        {
            return FromSeconds(min * 60);
        }

        public static TimeTick FromHours(double hours)
        {
            return FromMinutes(hours * 60);
        }

        public override string ToString()
        {
            return Ticks.ToString();
        }
    }
}
