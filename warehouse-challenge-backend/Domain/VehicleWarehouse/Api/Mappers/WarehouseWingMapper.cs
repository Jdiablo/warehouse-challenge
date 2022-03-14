using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.Mappers
{
    public static class WarehouseWingMapper
    {
        public static WarehouseWingDTO ToDTO(WarehouseWing warehouseWing)
        {
            return new WarehouseWingDTO()
            {
                Name = warehouseWing.Name,
                Vehicles = warehouseWing.Vehicles.OrderBy(x => x.DateAdded).Select(x => VehicleMapper.ToShortDto(x))
            };
        }
    }
}
