using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.DTO
{
    public class VehicleShortDTO
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string DateAdded { get; set; }
    }
}
