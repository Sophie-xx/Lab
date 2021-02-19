using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class Author
    {
        [Required]
        public string GivenName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Url]
        public string WebsiteAddress { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(56)]
        public string Country { get; set; }

        [StringLength(85)]
        public string Province { get; set; }

        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
    }
}
