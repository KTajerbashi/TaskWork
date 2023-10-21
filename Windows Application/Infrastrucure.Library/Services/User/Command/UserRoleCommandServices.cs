using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services
{
    public class UserRoleCommandServices : BaseService<UserRole, DatabaseContext>
    {
        public UserRoleCommandServices(DatabaseContext context) : base(context)
        {
        }
    }
}
