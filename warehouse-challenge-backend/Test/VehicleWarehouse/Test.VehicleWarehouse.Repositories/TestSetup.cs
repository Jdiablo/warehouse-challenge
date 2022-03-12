using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.FileRepository.Repository;

namespace Test.VehicleWarehouse.Repositories
{
    public class TestSetup
    {
        public IWarehouseRepository SetupWarehouseFileRepo()
        {
            return new WarehouseRepository("warehouses.json");
        }
    }
}
