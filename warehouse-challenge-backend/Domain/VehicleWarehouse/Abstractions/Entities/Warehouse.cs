using Domain.Common.Abstractions.Entities;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public class Warehouse : IdentifiableEntity<string>
    {
        public string Name { get; set; }

        public string LocationLat { get; set; }

        public string LocationLong { get; set; }

        public WarehouseWing WarehouseWing { get; set; }
    }
}
