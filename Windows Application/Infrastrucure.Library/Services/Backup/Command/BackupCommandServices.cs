using Domain.Library.Models.Entity;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services.BackupService
{
    public class BackupCommandServices : BaseService<Backup, DatabaseContext>
    {
        public BackupCommandServices(DatabaseContext context) : base(context)
        {
        }
    }
}
