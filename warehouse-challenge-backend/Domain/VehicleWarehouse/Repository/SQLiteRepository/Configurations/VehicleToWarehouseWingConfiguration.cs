using Domain.VehicleWarehouse.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Configurations
{
    public class VehicleToWarehouseWingConfiguration : IEntityTypeConfiguration<VehicleToWarehouseWing>
    {
        public void Configure(EntityTypeBuilder<VehicleToWarehouseWing> builder)
        {
            builder.ToTable("vehicle_to_warehouse_wing");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.VehicleId).HasColumnName("vehicle_id");
            builder.Property(x => x.WarehouseWingId).HasColumnName("warehouse_wing_id");

            builder.HasOne(x => x.Vehicle).WithOne();
            builder.HasOne(x => x.WarehouseWing).WithMany(x => x.Vehicles);
        }
    }
}
