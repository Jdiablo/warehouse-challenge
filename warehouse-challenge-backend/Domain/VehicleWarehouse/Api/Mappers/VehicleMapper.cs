using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Api.DTO;

namespace Domain.VehicleWarehouse.Api.Mappers
{
    public static class VehicleMapper
    {
        public static VehicleShortDTO ToShortDto(Vehicle vehicle)
        {
            return new VehicleShortDTO()
            {
                Id = vehicle.Id,
                DateAdded = vehicle.DateAdded.ToShortDateString(),
                Make = vehicle.Make,
                Model = vehicle.Model,
            };
        }

        public static VehicleFullDTO ToFullDto(Vehicle vehicle)
        {
            return new VehicleFullDTO()
            {
                Id = vehicle.Id,
                DateAdded = vehicle.DateAdded.ToShortDateString(),
                Make = vehicle.Make,
                Model = vehicle.Model,
                Licensed = vehicle.Licensed,
                Price = vehicle.Price,
                YearModel = vehicle.YearModel,
            };
        }
    }
}
