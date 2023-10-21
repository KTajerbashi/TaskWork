using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Library.Services.TaskService
{
    public class TaskQueryServices : BaseService<TaskWork,DatabaseContext>
    {
        public TaskQueryServices(DatabaseContext context) : base(context)
        {
        }

        public List<TaskWork> GetAllIncluded()
        {
            return _context.Tasks.Include("Samaneh")
                    .Where(x => !x.IsDeleted && (!x.IsPassed || !x.IsDeliver))
                    .OrderByDescending(x => !x.IsPassed)
                    .ThenByDescending(x => !x.IsDeliver)
                    .Take(14).ToList();
        }
    }
}
