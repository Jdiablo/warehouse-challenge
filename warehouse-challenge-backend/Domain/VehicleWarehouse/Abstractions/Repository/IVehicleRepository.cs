using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.Common.Abstractions.Repository;

namespace Domain.VehicleWarehouse.Abstractions.Repository
{
    public interface IVehicleRepository : IGetRepository<Vehicle, int>
    {
    }
}
