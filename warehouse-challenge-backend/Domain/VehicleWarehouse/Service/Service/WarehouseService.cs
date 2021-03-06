using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Abstractions.Repository;
using Domain.VehicleWarehouse.Abstractions.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Services.Service
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseService (IWarehouseRepository warehouseRepository) : base()
        {
            _warehouseRepository = warehouseRepository;
        }

        public async Task<IEnumerable<Warehouse>> GetAllAsync()
        {
            return await _warehouseRepository.GetAllAsync();
        }

        public async Task<Warehouse> GetAsync(object id)
        {
            return await _warehouseRepository.GetAsync((int)id);
        }
    }
}
