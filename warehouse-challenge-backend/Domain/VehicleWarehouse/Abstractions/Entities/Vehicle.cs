using Domain.Common.Abstractions.Entities;
using System;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public class Vehicle : IdentifiableEntity<int>
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int YearModel { get; set; }

        public decimal Price { get; set; }

        public bool Licensed { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
