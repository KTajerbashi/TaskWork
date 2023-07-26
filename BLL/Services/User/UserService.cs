using BEE.Models.Entity;
using BLL.BaseServices;
using DAL.DatabaseContext;

namespace BLL.Services
{
    public class UserService : GenericService<User>
    {
        private readonly DatabaseContext _contex;
        public UserService(DatabaseContext context) : base(context)
        {
            _contex = context;
        }
    }
}
