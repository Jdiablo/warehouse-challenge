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
    public class VehicleCartConfiguration : IEntityTypeConfiguration<VehicleCartItem>
    {
        public void Configure(EntityTypeBuilder<VehicleCartItem> builder)
        {
            builder.ToTable("vehicle_cart");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
           
            builder.Property(x => x.VehicleId).HasColumnName("vehicle_id");

            builder.HasOne(x => x.Vehicle).WithOne();
        }
    }
}
