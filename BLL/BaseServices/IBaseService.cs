using BEE.BaseEntity;
using BEE.Entities;
using BLL.BaseDTO;
using DAL.DatabaseContext;
using System.Data.Entity.Migrations;

namespace BLL.BaseServices
{
    public interface IBaseService
    {
    }
    public abstract class BaseService<TEntity> : IBaseService 
        where TEntity : class
    {
        private readonly DatabaseContext _context;
        protected BaseService(DatabaseContext context)
        {
            _context = context;
        }
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

    }

    public abstract class GenericService<TEntity>: BaseService<TEntity>
        where TEntity : GeneralEntity
    {
        private readonly DatabaseContext _context;
        protected GenericService(DatabaseContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
        public TEntity GetEntity(long id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
