using MasterDataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MasterDataAPI
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContext ):base(dbContext)
        {
                
        }

        public DbSet<LOBMaster> lOBMaster { get; set; }        
        public DbSet<AppMaster> appMaster { get; set; }
        public DbSet<AppEnvironment> appEnvironment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
