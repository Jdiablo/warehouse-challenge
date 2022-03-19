using Domain.Common.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Abstractions.Repository
{
    public interface IVehicleCartRepository : IGetRepository<VehicleCartItem, int>, IPutRepository<VehicleCartItem>
    {
    }
}
