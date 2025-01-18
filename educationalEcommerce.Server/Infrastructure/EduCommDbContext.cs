using educationalEcommerce.Server.Domain.Entities;
using educationalEcommerce.Server.Domain.TryEntities;
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

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Item> Items { get; set; }


        public DbSet<MainMod> MainMods { get; set; }
        public DbSet<ModAlt> ModAlts { get; set; }
        public DbSet<ModIncDec> ModIncDecs { get; set; }
        public DbSet<ModIncDecItem> ModIncDecItems { get; set; }
        public DbSet<ModAltItem> ModAltItems { get; set; }


    }

}
