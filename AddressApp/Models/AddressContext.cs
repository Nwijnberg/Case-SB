using Microsoft.EntityFrameworkCore;

namespace AddressApp.Models
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options)
            : base(options)
        {
        }

        public DbSet<AddressData> ADDRESS_DATA { get; set; }
    }
}