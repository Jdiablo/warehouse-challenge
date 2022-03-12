using Domain.VehicleWarehouse.Abstractions.Entities;
using Domain.VehicleWarehouse.FileRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Mappers
{
    public static class VehicleMapper
    {
        public static Vehicle FromDTO(VehicleDTO dto)
        {
            var result = new Vehicle()
            {
                Id = dto.Id,
                Licensed = dto.Licensed,
                Make = dto.Make,
                Model = dto.Model,
                Price = (decimal)dto.Price,
                YearModel = dto.YearModel,
            };

            if (DateTime.TryParseExact(dto.DateAdded, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.AssumeLocal, out DateTime dateAdded))
                result.DateAdded = dateAdded;

            return result;
        }

        public static IEnumerable<Vehicle> FromDTO(IEnumerable<VehicleDTO> dtos)
            => dtos.Select(x => FromDTO(x));
    }
}
