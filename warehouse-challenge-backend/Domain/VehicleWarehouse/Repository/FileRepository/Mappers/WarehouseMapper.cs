using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.FileRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Mappers
{
    public static class WarehouseMapper
    {
        public static Warehouse FromDTO(WarehouseDTO dto)
        {
            return new Warehouse()
            {
                Id = dto.Id,
                Name = dto.Name,
                LocationLat = dto.Location?.Lat,
                LocationLong = dto.Location?.Long,
                WarehouseWing = new WarehouseWing()
                {
                    Name = dto.Cars?.Location,
                    Vehicles = VehicleMapper.FromDTO(dto.Cars?.Vehicles)
                }
            };
        }

        public static IEnumerable<Warehouse> FromDTO(IEnumerable<WarehouseDTO> dtos)
            => dtos.Select(x => FromDTO(x));
    }
}
