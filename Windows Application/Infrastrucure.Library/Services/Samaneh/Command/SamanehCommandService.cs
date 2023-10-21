using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services.SamanehService
{
    public class SamanehCommandService : BaseService<Samaneh, DatabaseContext>
    {
        public SamanehCommandService(DatabaseContext context) : base(context)
        {
        }
    }
}
