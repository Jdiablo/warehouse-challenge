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
    public class WarehouseWingConfiguration : IEntityTypeConfiguration<WarehouseWing>
    {
        public void Configure(EntityTypeBuilder<WarehouseWing> builder)
        {
            builder.ToTable("warehouse_wing");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.WarehouseId).HasColumnName("warehouse_id");

            //builder.HasOne(x => x.Warehouse).WithOne(x => x.WarehouseWing);
            builder.HasMany(x => x.Vehicles).WithOne(x => x.WarehouseWing).HasConstraintName("warehouse_wing_id");
        }
    }
}
