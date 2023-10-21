using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.TaskService
{
    public class TaskCommandServices : BaseService<TaskWork, DatabaseContext>
    {
        public TaskCommandServices(DatabaseContext context) : base(context)
        {
        }
    }
}
