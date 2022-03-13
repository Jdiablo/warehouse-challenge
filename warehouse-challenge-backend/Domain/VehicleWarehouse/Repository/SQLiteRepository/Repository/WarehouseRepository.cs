﻿using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class WarehouseRepository : BaseRepository<VehicleWarehouseDbContext, Warehouse, int>, IWarehouseRepository
    {
        public WarehouseRepository(VehicleWarehouseDbContext dbContext) : base(dbContext)
        {

        }

        protected override IQueryable<Warehouse> Queryable => base.Queryable
            .Include(x => x.WarehouseWing)
                .ThenInclude(x => x.Vehicles)
                    .ThenInclude(x => x.Vehicle);
    }
}
