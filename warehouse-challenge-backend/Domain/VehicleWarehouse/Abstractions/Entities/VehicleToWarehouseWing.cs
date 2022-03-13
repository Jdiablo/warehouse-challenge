using Domain.Common.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public class VehicleToWarehouseWing : IdentifiableEntity<int>
    {
        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public int WarehouseWingId { get; set; }

        public WarehouseWing WarehouseWing { get; set; }
    }
}
