using System;

namespace Singleton
{
    public class MainSingleton
    {
        public static void Make()
        {
            Video video = new Video();
            Console.WriteLine(video.Picture);

            SettingSinglton.Instance.Volume = 19;

            Voicer voicer = new Voicer();
            voicer.Voice();

            SettingSinglton.Instance.Volume = 98;
            voicer.Voice();

            SettingSinglton.Instance.Volume = 65;
            voicer.Voice();
        }
    }
}
