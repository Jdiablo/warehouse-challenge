using Domain.Common.Abstractions.Entities;
using Domain.Common.Abstractions.Repository;
using Domain.VehicleVehicle.Services.Service;
using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Services.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.VehicleWarehouse.Serivces
{
    public class TestSetup
    {
        //private T SetupGetRepo<T, TEntity, TIdentifier>() where T : IGetRepository<TEntity, TIdentifier>
        //        where TEntity : IEntity
        //        where TIdentifier : class
        //{
        //    var mockedRepo = new Mock<T<TEntity, TIdentifier>>();
        //    mockedRepo.Setup(x => x.GetAllAsync()).Returns(() =>
        //    {
        //        var list = new List<IEntity>();
        //        list.Add(Moq.It.IsAny<IEntity>());
        //        return Task.FromResult(list as IEnumerable<TEntity>);
        //    });
        //    return mockedRepo.Object;
        //}

        private IWarehouseRepository SetupWarehouseRepo()
        {
            var repo = new Mock<IWarehouseRepository>();
            repo.Setup(x => x.GetAllAsync()).Returns(() =>
            {
                var list = new List<Warehouse>();
                list.Add(Moq.It.IsAny<Warehouse>());
                return Task.FromResult(list as IEnumerable<Warehouse>);
            });
            repo.Setup(x => x.GetAsync(It.IsAny<int>())).Returns(() => Task.FromResult(new Warehouse()));

            return repo.Object;
        }

        private IVehicleRepository SetupVehicleRepo(Func<Vehicle, Vehicle> vehicleBuilder = null)
        {
            var repo = new Mock<IVehicleRepository>();
            repo.Setup(x => x.GetAllAsync()).Returns(() =>
            {
                var list = new List<Vehicle>();
                list.Add(Moq.It.IsAny<Vehicle>());
                return Task.FromResult(list as IEnumerable<Vehicle>);
            });

            var vehicle = new Vehicle();
            if (vehicleBuilder != null)
                vehicle = vehicleBuilder(vehicle);

            repo.Setup(x => x.GetAsync(It.IsAny<int>())).Returns(() => Task.FromResult(vehicle));

            return repo.Object;
        }

        public WarehouseService SetupWarehouseService()
        {
            return new WarehouseService(SetupWarehouseRepo());
        }

        public VehicleService SetupVehicleService(Func<Vehicle, Vehicle> vehicleBuilder = null)
        {
            return new VehicleService(SetupVehicleRepo(vehicleBuilder));
        }
    }
}
