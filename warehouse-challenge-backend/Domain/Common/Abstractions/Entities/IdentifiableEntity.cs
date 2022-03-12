using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.Abstractions.Entities
{
    public abstract class IdentifiableEntity<TIdentity> : IEntity
    {
        public virtual TIdentity Id { get; set; }
    }
}
