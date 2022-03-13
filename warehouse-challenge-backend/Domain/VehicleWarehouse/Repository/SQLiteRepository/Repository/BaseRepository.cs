using Domain.Common.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.VehicleWarehouse.SQLiteRepository.Repository
{
    public class BaseRepository<TDbContext, TEntity, TIdentifier> where TDbContext : DbContext where TEntity : IdentifiableEntity<TIdentifier>
    {
        private readonly TDbContext _dbContext;

        public BaseRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected virtual IQueryable<TEntity> Queryable => _dbContext.Set<TEntity>().AsQueryable();

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Queryable.ToListAsync();
        }

        public virtual async Task<TEntity> GetAsync(TIdentifier id)
        {
            return await Queryable.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
