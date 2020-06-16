using Microsoft.EntityFrameworkCore;
using VillaApp.Data.Entities;

namespace VillaApp.Data.DatabaseContexts.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Property> Properties { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}