using Builder.MailBuilder;
using System;

namespace Builder
{
    public class MainBuilder
    {
        public static void Make()
        {
            var user = new UserBuilder().AddFirstName("Vladimir")
                .AddSecondName("Vladimirovich").AddLastName("Petrushenko")
                .AddAge(29).AddSex(Sex.man)
                .Build();

            Console.WriteLine(user);

            var post = new MailBuilder.MailBuilder(user)
                .AddCountry("Belarussia").AddPostIndex(247710)
                .AddArea("Gomelskaya").AddStreet("Komsomolskaya 27")
                .AddApartment("321")
                .Build();

            Console.WriteLine(post);
        }
    }
}
