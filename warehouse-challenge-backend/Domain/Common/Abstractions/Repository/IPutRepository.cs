using Domain.Common.Abstractions.Entities;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Repository
{
    /// <summary>
    /// Represents some repository for add\update data
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TIdentifier">Some entity idtifier type (string\int\etc)</typeparam>
    public interface IPutRepository<TEntity> where TEntity : IEntity
    {
        public Task AddAsync(TEntity entity);
    }
}
