namespace Builder.MailBuilder
{
    class Mail
    {
        public User User { get; set; }
        public string Apartment { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
        public int PostIndex { get; set; }

        public override string ToString()
        {
            return $"{User} - {PostIndex} - {Country}, {Area}, {District ?? ""}, {Street} {Apartment}";
        }
    }
}
