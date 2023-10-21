using Domain.Library.Models.Entity;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services.LoggerService
{
    public class LoggerQueryServices : BaseService<Logger, DatabaseContext>
    {
        public LoggerQueryServices(DatabaseContext context) : base(context)
        {
        }
    }
}
