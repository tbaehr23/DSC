using DSC.Database.Domain;
using Microsoft.EntityFrameworkCore;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace DSC.Database
{
    public class DSCContext : DbContext
    {
        public DSCContext(DbContextOptions<DSCContext> options):base(options)
        {
        }

        // for Add-Migration and Update-Database in Microsoft.EntityFrameworkCore.Tools
        // Add-Migration -Name init -StartupProject DSC.Database.Initialize
        // Update-Database -StartupProject DSC.Database.Initialize
        public DSCContext()
        {
        }

        // for Add-Migration and Update-Database in Microsoft.EntityFrameworkCore.Tools
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=DSC;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Job> Jobs { get; set; }
    }
}
