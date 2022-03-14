using Domain.VehicleVehicle.Services.Service;
using Domain.VehicleWarehouse.Abstractions.Service;
using Domain.VehicleWarehouse.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.VehicleWarehouse.Services
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddVehicleWarehouse(this IServiceCollection serviceCollection)
            => serviceCollection
            .AddTransient<IWarehouseService, WarehouseService>()
            .AddTransient<IVehicleService, VehicleService>();
    }
}
