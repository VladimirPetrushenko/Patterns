using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Container
{
    class Container
    {
        private static Container instance;
        private Dictionary<Type, object> dic;

        public Container()
        {
            dic = new Dictionary<Type, object>();
        }

        public static Container Instance => instance ??= new Container();

        public void Register<T, U>()
            where U : T, new()
            => dic.Add(typeof(T), new U());
        public void Unregister<T>() => dic.Remove(typeof(T));
        public T Extract<T>() => (T)dic[typeof(T)];
    }
}
