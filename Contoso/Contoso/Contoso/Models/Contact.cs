using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Models
{
    public class Contact
    {
        [Required]
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [MinLength(2), MaxLength(15)]
        public string LastName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
