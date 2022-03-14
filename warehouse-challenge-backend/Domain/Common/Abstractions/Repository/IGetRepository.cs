using Domain.Common.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Repository
{
    /// <summary>
    /// Represents some repository for retrieving data ('get' operations)
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TIdentifier">Some entity idtifier type (string\int\etc)</typeparam>
    public interface IGetRepository<TEntity, TIdentifier> where TEntity : IEntity
    {
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<TEntity> GetAsync(TIdentifier id);
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
    }
}
