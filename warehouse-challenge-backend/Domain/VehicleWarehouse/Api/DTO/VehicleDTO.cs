using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public int YearModel { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public string DateAdded { get; set; }
    }
}
