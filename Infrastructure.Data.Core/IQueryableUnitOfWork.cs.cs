using System.Data.Objects;

using Domain.Core;
using Domain.Core.Entities;

namespace Infrastructure.Data.Core
{
    public interface IQueryableUnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Create a object set for a type TEntity
        /// </summary>
        /// <typeparam name="TEntity">Type of elements in object set</typeparam>
        /// <returns>Object set of type {TEntity}</returns>
        IObjectSet<TEntity> CreateSet<TEntity>() where TEntity : class,IObjectWithChangeTracker;

    }
}
