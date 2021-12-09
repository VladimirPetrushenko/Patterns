namespace Observer.University
{
    public class Univer
    {
        public static void Make()
        {
            var professor = new Professor("Malahov");

            var vladimir = new Student("Vladimir");
            var evgeniy = new Student("Evgeniy");
            var margorita = new Student("Margorita");

            professor.Attach(vladimir);
            professor.Attach(evgeniy);

            professor.Make("New lecture");

            professor.Attach(margorita);

            professor.Make("Mathematics");
        }
    }
}
