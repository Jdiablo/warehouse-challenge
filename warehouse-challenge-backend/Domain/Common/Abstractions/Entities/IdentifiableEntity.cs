using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Entities
{
    /// <summary>
    /// Represent some identifiable entity that has some identifying property (int, string etc.)
    /// </summary>
    /// <typeparam name="TIdentity"></typeparam>
    public abstract class IdentifiableEntity<TIdentity> : IEntity
    {
        public virtual TIdentity Id { get; set; }
    }
}
