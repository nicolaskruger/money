﻿namespace Money.Data
{
    using Microsoft.EntityFrameworkCore;
    using Money.Models;

    public class MoneyDbContext : DbContext
    {
        private readonly IConfiguration config;

        public MoneyDbContext(IConfiguration config) => this.config = config;

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(this.config["ConnectionString"] ?? string.Empty);
        }
    }
}
