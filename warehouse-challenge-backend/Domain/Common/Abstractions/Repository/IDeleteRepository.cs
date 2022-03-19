using Domain.Common.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Repository
{
    /// <summary>
    /// Represents some repository for deleting data
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IDeleteRepository<TEntity> where TEntity : IEntity
    {
        Task DeleteAsync(Expression<Func<TEntity, bool>> expression);
    }
}
