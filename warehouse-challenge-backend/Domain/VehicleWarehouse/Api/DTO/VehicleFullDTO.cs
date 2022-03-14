using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.DTO
{
    public class VehicleFullDTO : VehicleShortDTO
    {
        public int YearModel { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public string WarehouseName { get; set; }

        public string LocationName { get; set; }

        public string LocationLat { get; set; }

        public string LocationLong { get; set; }
    }
}
