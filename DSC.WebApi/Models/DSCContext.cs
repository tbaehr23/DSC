using Microsoft.EntityFrameworkCore;

namespace DSC.WebApi.Models
{
    public class DSCContext : DbContext
    {
        public DSCContext(DbContextOptions<DSCContext> options):base(options)
        {
            
        }
        public DbSet<Job> Jobs { get; set; }
    }
}
