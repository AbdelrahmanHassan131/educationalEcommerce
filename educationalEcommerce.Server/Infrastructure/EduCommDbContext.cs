using Microsoft.EntityFrameworkCore;

namespace educationalEcommerce.Server.Infrastructure
{
    public class EduCommDbContext : DbContext
    {
        public IConfiguration _configuration { get; set; }

        public EduCommDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DatabaseConnection"));

        }
    }

}
