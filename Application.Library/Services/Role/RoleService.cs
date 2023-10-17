using Domain.Library.KeyValues;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Library
{
    public class RoleService : GenericRepository<Role>
    {

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
