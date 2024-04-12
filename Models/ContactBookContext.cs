using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Models
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext(DbContextOptions<ContactBookContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    
    }
}
