using BusinessLogic.Library.UnitOfWork;
using Infrastrucure.Library.UnitOfWork;
using Ninject.Modules;
using System;

namespace TicketApplication.Repositories.Ninjict
{
    public class NinjectBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
