using Microsoft.AspNetCore.Identity;
using System;

namespace Contoso.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string FavoriteToy { get; set; }
    }
}
