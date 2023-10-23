using BusinessLogic.Library;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;

namespace Infrastrucure.Library.Repository.RoleService
{
    public class RoleService : BaseService<Role, DatabaseContext>
    {
        public Result<List<ComboboxItem<long>>> ReadKeyValue()
        {
            var res = _context.Roles.Where(x => !x.IsDeleted && x.IsActive).Select(r => new ComboboxItem<long>
            {
                Text= r.Description,
                Value = r.ID,
            }).ToList();
            return new Result<List<ComboboxItem<long>>>
            {
                Data = res,
                Message = " ",
                Success = true
            };
        }
    }
}
