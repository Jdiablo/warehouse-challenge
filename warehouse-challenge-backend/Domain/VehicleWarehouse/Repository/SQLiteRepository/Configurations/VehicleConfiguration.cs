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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("vehicle");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.DateAdded).HasColumnName("date_added");
            builder.Property(x => x.Price).HasColumnName("price");
            builder.Property(x => x.Licensed).HasColumnName("licensed");
            builder.Property(x => x.Make).HasColumnName("make");
            builder.Property(x => x.Model).HasColumnName("model");
            builder.Property(x => x.YearModel).HasColumnName("year_model");
            builder.Property(x => x.WarehouseWingId).HasColumnName("warehouse_wing_id");

            builder.HasOne(x => x.WarehouseWing).WithMany(x => x.Vehicles);
        }
    }
}
