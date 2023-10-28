using BusinessLogic.Library;
using Domain.Library.KeyValues;
using Domain.Library.Models.Entity;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;

namespace Infrastrucure.Library.Repository.RoadMapPanel
{
    public class RoadmapService : BaseService<RoadmapLesson, DatabaseContext>
    {
        public RoadmapService() { }
        public Result<List<ComboboxItem<long>>> KeyValueList()
        {
            var data  = _context.RoadmapLessons.Where(x => x.ParentId == null ).Select(x => new ComboboxItem<long>
            {
                Text = x.Title,
                Value = x.ID
            }).ToList();
            return new Result<List<ComboboxItem<long>>>
            {
                Data = data,
                Message = "",
                Success = true

            };
        }
    }
}
