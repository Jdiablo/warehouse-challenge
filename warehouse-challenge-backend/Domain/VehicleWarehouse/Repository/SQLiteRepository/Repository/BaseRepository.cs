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

        protected virtual IQueryable<TEntity> ShortQueryable => _dbContext.Set<TEntity>().AsQueryable();

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
