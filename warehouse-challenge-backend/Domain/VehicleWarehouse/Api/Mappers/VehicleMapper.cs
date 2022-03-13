using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Api.DTO;

namespace Domain.VehicleWarehouse.Api.Mappers
{
    public static class VehicleMapper
    {
        public static VehicleShortDTO ToDto(Vehicle vehicle)
        {
            return new VehicleShortDTO()
            {
                Id = vehicle.Id,
                DateAdded = vehicle.DateAdded.ToShortDateString(),
                Make = vehicle.Make,
                Model = vehicle.Model,
            };
        }
    }
}
