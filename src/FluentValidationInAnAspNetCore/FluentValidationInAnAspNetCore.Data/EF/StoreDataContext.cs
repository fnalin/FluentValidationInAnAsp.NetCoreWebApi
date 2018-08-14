using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FluentValidationInAnAspNetCore.Data.EF
{
    public class StoreDataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public StoreDataContext(IConfiguration configuration) =>
                _configuration = configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("StoreConn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Maps.CustomerMap());
            modelBuilder.ApplyConfiguration(new Maps.EmployeeMap());
            modelBuilder.ApplyConfiguration(new Maps.ProductMap());
            modelBuilder.ApplyConfiguration(new Maps.OrderMap());
            modelBuilder.ApplyConfiguration(new Maps.OrderDetailsMap());

        }
    }
}
