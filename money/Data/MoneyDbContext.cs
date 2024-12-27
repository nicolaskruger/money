using Microsoft.EntityFrameworkCore;
using money.Models;

namespace money.Data
{
    public class MoneyDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public MoneyDbContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionString"] ?? "");
        }
    }
}
