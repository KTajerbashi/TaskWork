using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services.RoleService
{
    public class RoleCommandServices : BaseService<Role, DatabaseContext>
    {
        public RoleCommandServices(DatabaseContext context) : base(context)
        {
        }
    }
}
