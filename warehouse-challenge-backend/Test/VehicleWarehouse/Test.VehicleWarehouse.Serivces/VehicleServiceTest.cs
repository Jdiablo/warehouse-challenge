using Domain.VehicleWarehouse.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.VehicleWarehouse.Serivces;
using Xunit;

namespace Test.VehicleVehicle.Services
{
    public class VehicleServiceTest
    {
        private readonly IVehicleService _vehicleService = new TestSetup().SetupVehicleService();

        [Fact]
        public void GetAllVehicles()
        {
            var result = _vehicleService.GetAllAsync().Result;

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        public void GetVehicle()
        {
            var result = _vehicleService.GetAsync(1).Result;

            Assert.NotNull(result);
        }


        [Fact]
        public void GetNonLicensedVehicle_Prevented()
        {
            IVehicleService vehicleService = new TestSetup().SetupVehicleService((vehicle) =>
            {
                vehicle.Id = 2;
                vehicle.Licensed = false;
                return vehicle;
            });

            var result = vehicleService.GetAsync(2).Result;

            Assert.Null(result);
        }
    }
}
