using BusinessLogic.Library;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Library.Services.RoleService
{
    public class RoleQueryServices : BaseService<Role, DatabaseContext>
    {
        public RoleQueryServices(DatabaseContext context) : base(context)
        {
        }

        public Result<List<ComboboxItem<long>>> ReadKeyValue()
        {
            var item = _context.Roles.Where(x => x.IsActive && !x.IsDeleted).Select(x => new ComboboxItem<long>
            {
                Text = x.Description,
                Value = x.ID
            }).ToList();
            return new Result<List<ComboboxItem<long>>>
            {
                Data = item.ToList(),
                Success = true,
                Message = ""
            };
        }
    }
}
