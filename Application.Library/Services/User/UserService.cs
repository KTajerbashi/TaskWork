using DAL.DatabaseContext;
using Domain.Model;

namespace BusinessLogic.Library
{
    public class UserService : GenericRepository<User>
    {
        private readonly DatabaseContext _contex;
        public UserService(DatabaseContext context) : base(context)
        {
            _contex = context;
        }
    }
}
