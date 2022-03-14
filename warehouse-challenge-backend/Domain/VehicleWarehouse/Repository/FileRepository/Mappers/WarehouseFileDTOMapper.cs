using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.FileRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Mappers
{
    public static class WarehouseFileDTOMapper
    {
        public static Warehouse FromDTO(WarehouseFileDTO dto)
        {
            return new Warehouse()
            {
                Id = int.Parse(dto.Id),
                Name = dto.Name,
                LocationLat = dto.Location?.Lat,
                LocationLong = dto.Location?.Long,
                WarehouseWing = new WarehouseWing()
                {
                    Name = dto.Cars?.Location,
                    Vehicles = VehicleFileDTOMapper.FromDTO(dto.Cars?.Vehicles)
                }
            };
        }

        public static IEnumerable<Warehouse> FromDTO(IEnumerable<WarehouseFileDTO> dtos)
            => dtos.Select(x => FromDTO(x));
    }
}
