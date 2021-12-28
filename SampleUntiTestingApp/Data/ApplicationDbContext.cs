using Microsoft.EntityFrameworkCore;
using SampleUntiTestingApp.Models;

namespace SampleUntiTestingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CreditCardApplication> CreditCardApplications { get; set; }
    }
}
