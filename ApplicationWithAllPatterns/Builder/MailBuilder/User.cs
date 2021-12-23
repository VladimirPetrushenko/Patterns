namespace Builder.MailBuilder
{
    class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {SecondName ?? "" } {LastName} - {Age} - {Sex}";
        }
    }
}
