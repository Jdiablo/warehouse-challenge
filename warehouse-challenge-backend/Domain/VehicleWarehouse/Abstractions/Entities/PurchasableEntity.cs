using Domain.Common.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public abstract class PurchasableEntity<TIdentity> : IdentifiableEntity<TIdentity>
    {
        public decimal Price { get; set; }
    }
}
