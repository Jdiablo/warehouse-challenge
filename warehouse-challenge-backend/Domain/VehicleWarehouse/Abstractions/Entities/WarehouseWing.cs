using Domain.Common.Abstractions.Entities;
using System.Collections.Generic;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public class WarehouseWing : IdentifiableEntity<int>
    {
        public string Name { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }

        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
