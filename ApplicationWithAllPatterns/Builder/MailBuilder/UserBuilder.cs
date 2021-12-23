namespace Builder.MailBuilder
{
    class UserBuilder
    {
        private readonly User user;

        public UserBuilder()
        {
            user = new User();
        }

        public UserBuilder AddFirstName(string name)
        {
            user.FirstName = name;
            return this;
        }

        public UserBuilder AddSecondName(string name)
        {
            user.SecondName = name;
            return this;
        }

        public UserBuilder AddLastName(string name)
        {
            user.LastName = name;
            return this;
        }

        public UserBuilder AddAge(int age)
        {
            user.Age = age;
            return this;
        }

        public UserBuilder AddSex(Sex sex)
        {
            user.Sex = sex;
            return this;
        }

        public User Build()
        {
            return user;
        }
    }
}
