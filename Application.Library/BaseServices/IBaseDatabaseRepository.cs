using Infrastrucure.Library.DatabaseService;
using System.Data;

namespace BusinessLogic.Library
{
    public interface IBaseDatabaseRepository
    {
        DataTable Execute(string query);
    }
    public class BaseDatabaseRepository : IBaseDatabaseRepository
    {
        private readonly IBaseQuery _repository;
        public BaseDatabaseRepository(
            )
        {
            _repository = new BaseQuery();
        }

        public DataTable Execute(string query)
        {
            return _repository.Execute(query);
        }
    }
}
