using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services
{
    public class UserRoleQueryServices : BaseService<UserRole, DatabaseContext>
    {
        public UserRoleQueryServices(DatabaseContext context) : base(context)
        {
        }
    }
}
