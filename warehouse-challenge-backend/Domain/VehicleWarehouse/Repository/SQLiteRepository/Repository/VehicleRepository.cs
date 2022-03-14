using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class VehicleRepository : BaseRepository<VehicleWarehouseDbContext, Vehicle, int>, IVehicleRepository
    {
        public VehicleRepository(VehicleWarehouseDbContext dbContext) : base(dbContext)
        {
        }

        protected override IQueryable<Vehicle> FullQueryable => base.FullQueryable
            .Include(x => x.WarehouseWing)
                .ThenInclude(x => x.Warehouse);
    }
}
