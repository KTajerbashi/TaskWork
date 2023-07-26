using DAL.DatabaseContext;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace BusinessLogic.Library
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DatabaseContext _context = null;

        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new DatabaseContext();
            //Whatever class name we specify while creating the instance of GenericRepository
            //That class name will be stored in the table variable
            table = _context.Set<T>();
        }
        //Using the Parameterized Constructor, 
        //we are initializing the context object and table variable
        public GenericRepository(DatabaseContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        //This method will return all the Records from the table
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        //This method will return the specified record from the table
        //based on the ID which it received as an argument
        public T GetById(object id)
        {
            return table.Find(id);
        }
        //This method will Insert one object into the table
        //It will receive the object as an argument which needs to be inserted into the database
        public void Insert(T obj)
        {
            //It will mark the Entity state as Added State
            table.Add(obj);
        }
        //This method is going to update the record in the table
        //It will receive the object as an argument
        public void Update(T obj)
        {
            //First attach the object to the table
            table.Attach(obj);
            //Then set the state of the Entity as Modified
            _context.Entry(obj).State = EntityState.Modified;
        }
        //This method is going to remove the record from the table
        //It will receive the primary key value as an argument whose information needs to be removed from the table
        public void Delete(object id)
        {
            //First, fetch the record from the table
            T existing = table.Find(id);
            //This will mark the Entity State as Deleted
            table.Remove(existing);
        }
        //This method will make the changes permanent in the database
        //That means once we call Insert, Update, and Delete Methods, 
        //Then we need to call the Save method to make the changes permanent in the database
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
