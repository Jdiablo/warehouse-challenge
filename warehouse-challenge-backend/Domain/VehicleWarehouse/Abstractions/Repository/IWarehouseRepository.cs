using Domain.Common.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Entities;

namespace Domain.VehicleWarehouse.Abstractions.Repository
{
    public interface IWarehouseRepository : IGetRepository<Warehouse, string>
    {
    }
}
