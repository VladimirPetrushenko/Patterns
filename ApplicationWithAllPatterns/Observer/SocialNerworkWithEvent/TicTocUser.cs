using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.SocialNerworkWithEvent
{
    class TicTocUser : Account
    {
        private Action<TicTocUser, string> followers;
        public event Action<TicTocUser, string> Followers
        {
            add => followers += value;
            remove => followers -= value;
        }

        public TicTocUser(string name)
        {
            base.NickName = name;
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
            Console.WriteLine();
            var info = $"вышел контент {content}";

            Alert(this, info);

            followers?.Invoke(this, info);
        }

        public static TicTocUser operator +(TicTocUser user, TicTocUser follower)
        {
            Console.WriteLine($"Пользователь {follower.NickName} подписался на {user.NickName}");
            user.Followers += follower.Alert;
            return user;
        }

        public static TicTocUser operator -(TicTocUser user, TicTocUser follower)
        {
            Console.WriteLine($"Пользователь {follower.NickName} отписался от {user.NickName}");
            user.Followers -= follower.Alert;
            return user;
        }
    }
}
