namespace Singleton
{
    class SettingSinglton
    {
        private static SettingSinglton instance;

        private SettingSinglton()
        {
        }

        public static SettingSinglton Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingSinglton();
                return instance;
            }
        }

        public double Volume { get; set; }
        public bool HighQuality { get; set; }
        public bool Studying { get; set; }
    }
}
