using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.Api.DTO;

namespace Domain.VehicleWarehouse.Api.Mappers
{
    public static class VehicleMapper
    {
        public static VehicleDTO ToDto(Vehicle vehicle)
        {
            return new VehicleDTO()
            {
                Id = vehicle.Id,
                DateAdded = vehicle.DateAdded.ToShortDateString(),
                Licensed = vehicle.Licensed,
                Make = vehicle.Make,
                Model = vehicle.Model,
                Price = vehicle.Price,
                YearModel = vehicle.YearModel
            };
        }
    }
}
