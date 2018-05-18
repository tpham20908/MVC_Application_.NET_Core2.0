using Microsoft.AspNetCore.Identity;
using System;

namespace Contoso.Models
{
    public class AppplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string FavoriteToy { get; set; }
    }
}
