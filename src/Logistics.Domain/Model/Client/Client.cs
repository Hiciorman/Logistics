using System.ComponentModel.DataAnnotations;
using Logistics.Common;

namespace Logistics.Domain.Model.Client
{
    public class Client : Entity
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Address Address { get; set; }
    }
}