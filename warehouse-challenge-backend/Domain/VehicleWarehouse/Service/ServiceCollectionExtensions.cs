using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Services
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddVehicleWarehouse(this IServiceCollection serviceCollection)
            => serviceCollection;
    }
}
