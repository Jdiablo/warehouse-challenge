using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Api.DTO;


namespace Domain.VehicleWarehouse.Api.Mappers
{
    public static class WarehouseMapper
    {
        public static WarehouseDTO ToDto(Warehouse warehouse)
        {
            return new WarehouseDTO()
            {
                Id = warehouse.Id.ToString(),
                LocationLat = warehouse.LocationLat,
                LocationLong = warehouse.LocationLong,
                Name = warehouse.Name,
                WarehouseWing = WarehouseWingMapper.ToDTO(warehouse.WarehouseWing)
            };
        }
    }
}
