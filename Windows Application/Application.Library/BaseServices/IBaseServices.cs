using BusinessLogic.Library.DatabaseService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Library.BaseServices
{
    public interface IBaseServices<TEntity, TContext>
        where TEntity : class
        where TContext : IDatabaseContext, new()
    {
        Task<int> Insert(TEntity entity);
        Task<int> InsertAsync(TEntity entity);
        Task<int> AddOrUpdate(TEntity entity);
        Task<int> Update(TEntity entity);
        Task<int> Delete(TEntity entity);
        Task<int> DisActive(object Id);
        Task<TEntity> Delete(object Id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(object Id);
        Task<int> Save();
        Task<int> SaveAsync();
    }
}
