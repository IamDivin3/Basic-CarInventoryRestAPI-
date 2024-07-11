using CarInventoryREST.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarInventoryREST.DbModel
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }
    }
}
