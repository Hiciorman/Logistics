using Logistics.Domain.Model.Client;

namespace Blog.ObjectMothers
{
    public class ClientObjectMother
    {
        public static Client CreateClient()
        {
            var client = new Client
            {
                FirstName = "Johnny",
                LastName = "Cash",
                Email = "johnny.cash@gmail.com",
                PhoneNumber = "666-666-666",
                Address = new Address("Street", "City", "Region", "Cpuntry", "PostalCode")
            };

            return client;
        }
    }
}
