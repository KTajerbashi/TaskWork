using Ninject.Modules;

namespace TicketApplication.Repositories.Ninjict
{
    public class NinjectBinding : NinjectModule
    {
        public override void Load()
        {
            //Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
