using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Configurations
{
    public static class ModelBuilderConfigurations
    {

        public static ModelBuilder WithWarehouse(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration())
                .ApplyConfiguration(new WarehouseWingConfiguration())
                .ApplyConfiguration(new VehicleConfiguration())
                .ApplyConfiguration(new VehicleToWarehouseWingConfiguration());

            return modelBuilder;
        }
    }
}
