using Domain.Library.Models.Entity;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services
{
    public class BackupQueryServices : BaseService<Backup, DatabaseContext>
    {
        public BackupQueryServices(DatabaseContext context) : base(context)
        {
        }
    }
}
