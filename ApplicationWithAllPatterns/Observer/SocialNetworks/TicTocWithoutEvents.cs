namespace Observer.SocialNetworks
{
    public class TicTocWithoutEvents
    {
        public static void Make()
        {
            var vladimir = new TicTocUser("Vladimir");

            var evgeniy = new TicTocUser("Evgeniy");
            var margo = new TicTocUser("Margorita");

            evgeniy.Subscribe(vladimir);
            margo.Subscribe(vladimir);

            vladimir.PublishContent("something");

            margo.Unsubscribe(vladimir);

            vladimir.PublishContent("new video");
        } 
    }
}
