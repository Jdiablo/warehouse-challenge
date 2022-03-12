using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.FileRepository.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVehicleWarehouse(this IServiceCollection serviceCollection, string jsonFilePath)
            => serviceCollection.AddTransient<IWarehouseRepository>((sp) => new WarehouseRepository(jsonFilePath));
    }
}
