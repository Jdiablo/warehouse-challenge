using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.DTO
{
    public class WarehouseDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string LocationLat { get; set; }

        public string LocationLong { get; set; }

        public WarehouseWingDTO WarehouseWing { get; set; }
    }
}
