using System;

namespace Observer.SocialNetworks
{
    class TicTocUser : Account
    {
        protected Action<TicTocUser, string> followers;

        public TicTocUser(string name)
        {
            base.NickName = name;
        }

        public void Subscribe(TicTocUser follower)
        {
            Console.WriteLine($"Пользователь {this.NickName} подписался на {follower.NickName}");
            follower.followers += this.Alert;
        }

        public void Unsubscribe(TicTocUser follower)
        {
            Console.WriteLine($"Пользователь {this.NickName} отписался от {follower.NickName}");
            follower.followers -= this.Alert;
        }

        public void Alert(TicTocUser user, string info)
        {
            if (this != user)
            {
                Console.WriteLine($"Лента {this.NickName}: У {user.NickName} {info}");
            }
            else
            {
                Console.WriteLine($"У меня ({user.NickName}) {info}");
            }
        }

        public void PublishContent(string content)
        {
            var info = $"вышел контент {content}";

            Alert(this, info);

            followers?.Invoke(this, info);
        }
    }
}
