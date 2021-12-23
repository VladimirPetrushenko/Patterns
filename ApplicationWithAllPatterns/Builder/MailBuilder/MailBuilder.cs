using System;

namespace Builder.MailBuilder
{
    class MailBuilder
    {
        private readonly Mail mail;

        public MailBuilder(User user)
        {
            mail = new Mail
            {
                User = user
            };
        }

        public MailBuilder AddApartment(string apartment)
        {
            mail.Apartment = apartment;
            return this;
        }

        public MailBuilder AddStreet(string street)
        {
            mail.Street = street;
            return this;
        }

        public MailBuilder AddDistrict(string district)
        {
            mail.District = district;
            return this;
        }

        public MailBuilder AddArea(string area)
        {
            mail.Area = area;
            return this;
        }

        public MailBuilder AddCountry(string country)
        {
            mail.Country = country;
            return this;
        }

        public MailBuilder AddPostIndex(int postIndex)
        {
            mail.PostIndex = postIndex;
            return this;
        }

        public Mail Build()
        {
            
            return mail;
        }
    }
}
