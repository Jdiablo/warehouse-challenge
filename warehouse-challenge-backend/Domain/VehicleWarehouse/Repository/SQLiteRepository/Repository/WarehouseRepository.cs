using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class WarehouseRepository : BaseRepository<VehicleWarehouseDbContext, Warehouse, int>, IWarehouseRepository
    {
        public WarehouseRepository(VehicleWarehouseDbContext dbContext) : base(dbContext)
        {
        }

        protected override IQueryable<Warehouse> ShortQueryable => base.ShortQueryable
            .Include(x => x.WarehouseWing)
                .ThenInclude(x => x.Vehicles);

        public override async Task<IEnumerable<Warehouse>> GetAllAsync()
        {
            return await ShortQueryable.Select(x => new Warehouse()
            {
                Id = x.Id,
                LocationLat = x.LocationLat,
                LocationLong = x.LocationLong,
                Name = x.Name,
                WarehouseWing = new WarehouseWing()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Vehicles = x.WarehouseWing.Vehicles.Select(y => new Vehicle()
                    {
                        Id = y.Id,
                        DateAdded = y.DateAdded,
                        Make = y.Make,
                        Model = y.Model,
                        Licensed = y.Licensed
                    })
                }
            }).ToListAsync();
        }
    }
}
