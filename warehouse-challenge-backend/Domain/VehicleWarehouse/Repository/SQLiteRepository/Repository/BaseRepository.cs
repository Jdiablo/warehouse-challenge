using Domain.Common.Abstractions.Entities;
using Domain.Common.Abstractions.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class BaseRepository<TDbContext, TEntity, TIdentifier> : IGetRepository<TEntity, TIdentifier>
        where TDbContext : DbContext where TEntity : IdentifiableEntity<TIdentifier>
    {
        private readonly TDbContext _dbContext;

        public BaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Queryable set to work with 'short' entity data without any joins (if possible)
        /// Used by 'GetAllAsync' method
        /// </summary>
        protected virtual IQueryable<TEntity> ShortQueryable => _dbContext.Set<TEntity>().AsQueryable();

        /// <summary>
        /// Queryable set to work with 'full' entity data with any external joins. Child component should override with .Include (if possible)
        /// Used by 'GetAsync' method
        /// </summary>
        protected virtual IQueryable<TEntity> FullQueryable => _dbContext.Set<TEntity>().AsQueryable();

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await ShortQueryable.ToListAsync();
        }

        public virtual async Task<TEntity> GetAsync(TIdentifier id)
        {
            return await FullQueryable.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await FullQueryable.FirstOrDefaultAsync(expression);
        }
    }
}
