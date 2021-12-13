using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Voicer
    {
        public void Voice()
        {
            if (SettingSinglton.Instance.Volume < 20)
            {
                Console.WriteLine("thhhhhh....");
            }
            else if(SettingSinglton.Instance.Volume < 70)
            {
                Console.WriteLine("So sorry, you can't hear me because i speak quiet");
            }
            else
            {
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
        }
    }
}
