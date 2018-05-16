using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contoso.ViewModels
{
    public class ContactVM
    {
        [Required(ErrorMessage = "The Id field is required")]
        public int? Id { get; set; }

        [MinLength(2, ErrorMessage = "The First Name field must have at least 2 characters")]
        [MaxLength(15, ErrorMessage = "The First Name field must have at most 15 characters")]
        public string FirstName { get; set; }

        [MinLength(2, ErrorMessage = "The Last Name field must have at least 2 characters"),
            MaxLength(15, ErrorMessage = "The Last Name field must have at most 15 characters")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Phone number must be a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
