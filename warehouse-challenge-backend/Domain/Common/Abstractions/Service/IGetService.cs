using Domain.Common.Abstractions.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Service
{
    /// <summary>
    /// Represents some service for retrieving data ('get' operations)
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IGetService<TEntity> where TEntity : IEntity
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetAsync(object id);
    }
}
