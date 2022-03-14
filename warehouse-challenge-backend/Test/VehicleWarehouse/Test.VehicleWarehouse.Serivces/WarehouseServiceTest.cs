using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Service;
using Domain.VehicleWarehouse.Services.Service;
using Moq;
using System;
using Xunit;

namespace Test.VehicleWarehouse.Serivces
{
    public class WarehouseServiceTest
    {
        private readonly IWarehouseService warehouseService = new TestSetup().SetupWarehouseService();

        [Fact]
        public void GetAllWarehouses()
        {
            var result = warehouseService.GetAllAsync().Result;

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetWarehouse()
        {
            var result = warehouseService.GetAsync(1).Result;

            Assert.NotNull(result);
        }
    }
}
