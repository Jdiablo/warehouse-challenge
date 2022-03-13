using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Api.DTO
{
    public class WarehouseWingDTO
    {
        public string Name { get; set; }

        public IEnumerable<VehicleShortDTO> Vehicles { get; set; }
    }
}
