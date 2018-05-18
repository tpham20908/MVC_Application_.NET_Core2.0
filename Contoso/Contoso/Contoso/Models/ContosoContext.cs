using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Models
{
    public class ContosoContext : IdentityDbContext<ApplicationUser>
    {
        public ContosoContext(DbContextOptions<ContosoContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
