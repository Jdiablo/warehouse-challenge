using Domain.Common.Abstractions.Entities;
using Domain.Common.Abstractions.Repository;
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

        public WarehouseService SetupWarehouseService()
        {
            return new WarehouseService(SetupWarehouseRepo());
        }
    }
}
