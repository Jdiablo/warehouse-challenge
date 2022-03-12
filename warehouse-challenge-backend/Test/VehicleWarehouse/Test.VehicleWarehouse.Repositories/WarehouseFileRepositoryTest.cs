using Domain.VehicleWarehouse.Abstractions.Repository;
using System;
using Xunit;

namespace Test.VehicleWarehouse.Repositories
{
    public class WarehouseFileRepositoryTest
    {
        private readonly IWarehouseRepository _warehouseRepository = new TestSetup().SetupWarehouseFileRepo();

        [Fact]
        public void GetAllWarehouses()
        {
            var result = _warehouseRepository.GetAllAsync().Result;

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
