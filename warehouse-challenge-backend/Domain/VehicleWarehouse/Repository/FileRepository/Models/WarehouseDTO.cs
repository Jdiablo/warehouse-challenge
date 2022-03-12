using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Models
{
    public class WarehouseDTO
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("location")]
        public LocationDTO Location { get; set; }

        [JsonPropertyName("cars")]
        public CarsDTO Cars { get; set; }
    }
}
