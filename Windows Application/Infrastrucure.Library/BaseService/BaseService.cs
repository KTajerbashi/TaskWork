using BusinessLogic.Library.BaseServices;
using Domain.Base;
using Infrastructure.Library.DbContextData;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastrucure.Library.BaseService
{
    public abstract class BaseService<TEntity, TContext> : IBaseServices<TEntity, TContext>
        where TEntity : BaseEntity<long>
        where TContext : DatabaseContext, new()
    {
        protected DatabaseContext _context;
        public BaseService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<int> AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task<TEntity> Delete(long Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<int> DisActive(long Id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(Id);
            entity.IsActive = false;
            return 1;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().Where(x => !x.IsDeleted && x.IsActive).ToListAsync();
        }

        public async Task<TEntity> GetById(long Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<int> Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task<int> Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return 1;
        }
    }
}
