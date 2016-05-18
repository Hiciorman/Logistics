using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistics.Domain.Model.Client
{
    public class Address
    {
        public Address()
        {
            
        }

        public Address(string street, string city, string region, string country, string postalCode)
        {
            Street = street;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
        }


        [Required]
        [Column("Street")]
        [MaxLength(100)]
        public string Street { get; private set; }

        [Required]
        [Column("PostalCode")]
        [MaxLength(10)]
        public string PostalCode { get; private set; }

        [Required]
        [Column("City")]
        [MaxLength(100)]
        public string City { get; private set; }

        [Required]
        [Column("Region")]
        [MaxLength(100)]
        public string Region { get; private set; }

        [Required]
        [Column("Country")]
        [MaxLength(100)]
        public string Country { get; private set; }
    }
}
