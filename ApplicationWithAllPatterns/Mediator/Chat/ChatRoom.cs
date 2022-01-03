namespace Mediator.Chat
{
    internal static class ChatRoom
    {
        public static void Make()
        {
            var chatRoom = new ConsoleChat("Chat room number 15th");
            var vladimir = new User("Vladimir"); 
            var evgeniy = new User("Evgeniy"); 
            var margorita = new User("Margorita");
            var danila = new User("Danila");

            chatRoom.Join(vladimir);
            vladimir.PublicMessage("Do you hear me?");

            chatRoom.Join(evgeniy);
            evgeniy.PublicMessage("Hey do you hear me?");
            vladimir.PublicMessage("Yes, I do");

            chatRoom.Join(margorita);
            margorita.PrivateMessage(evgeniy.Name, "Hello");
            margorita.PublicMessage("Hi everyone");

            chatRoom.Join(danila);
            danila.PublicMessage("Hi there");
            evgeniy.PrivateMessage(danila.Name, "Hi");
            vladimir.PublicMessage("Hello");
        }
    }
}
