using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.SQLiteRepository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Domain.VehicleWarehouse.SQLiteRepository
{
    public class VehicleWarehouseDbContext : DbContext
    {
        public DbSet<Warehouse> VehicleWarehouse { get; set; }

        public VehicleWarehouseDbContext(DbContextOptions<VehicleWarehouseDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.WithWarehouse();
            base.OnModelCreating(modelBuilder);
        }
    }
}
