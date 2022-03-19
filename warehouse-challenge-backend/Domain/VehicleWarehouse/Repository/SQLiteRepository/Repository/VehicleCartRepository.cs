using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class VehicleCartRepository : BaseRepository<VehicleWarehouseDbContext, VehicleCartItem, int>, IVehicleCartRepository
    {
        public VehicleCartRepository(VehicleWarehouseDbContext dbContext) : base(dbContext)
        {
        }
    }
}
