using Domain.VehicleWarehouse.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.VehicleWarehouse.SQLiteRepository
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddVehicleWarehouseSqliteRepo(this IServiceCollection serviceCollection, string sqliteFilePath)
            => serviceCollection.AddDbContext<VehicleWarehouseDbContext>((sp, options) =>
            {
                options.UseSqlite($"Data Source={sqliteFilePath}");
            });
    }
}
