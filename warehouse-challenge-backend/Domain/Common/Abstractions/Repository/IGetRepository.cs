﻿using Domain.Common.Abstractions.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Common.Abstractions.Repository
{
    public interface IGetRepository
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
        }
    }
}
