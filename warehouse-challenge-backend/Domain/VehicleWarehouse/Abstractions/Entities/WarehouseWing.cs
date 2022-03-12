using Domain.Common.Abstractions.Entities;
using System.Collections.Generic;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public class WarehouseWing : IEntity
    {
        public string Name { get; set; }

        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
