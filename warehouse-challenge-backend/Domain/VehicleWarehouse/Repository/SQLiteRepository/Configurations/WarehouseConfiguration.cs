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
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("warehouse");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.LocationLat).HasColumnName("location_lat");
            builder.Property(x => x.LocationLong).HasColumnName("location_long");

            builder.HasOne(x => x.WarehouseWing).WithOne(x => x.Warehouse).HasConstraintName("warehouse_id");
        }
    }
}
