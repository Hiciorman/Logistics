using Logistics.Domain.Model.Courier;

namespace Blog.ObjectMothers
{
    public class CourierObjectMother
    {
        public static Courier CreateCourier()
        {
            var courier = new Courier
            {
                FirstName = "Johnny",
                LastName = "Cash",
                PhoneNumber = "666-666-666"
            };

            return courier;
        }
    }
}
