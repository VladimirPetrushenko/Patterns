namespace Singleton
{
    class Video
    {
        public string Picture { get; set; }
        public Video()
        {
            if (SettingSinglton.Instance.HighQuality)
            {
                Picture = "Hign picture";
            }
            else
            {
                Picture = "low picture";
            }
        }
        
    }
}
