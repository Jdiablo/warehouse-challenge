using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.FileRepository.Models
{
    public class CarsFileDTO
    {
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("vehicles")]
        public List<VehicleFileDTO> Vehicles { get; set; }
    }
}
