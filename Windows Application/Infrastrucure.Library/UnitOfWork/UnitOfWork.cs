using BusinessLogic.Library.Repositories.BackupServices.Commands;
using BusinessLogic.Library.Repositories.BackupServices.Queries;
using BusinessLogic.Library.Repositories.LoggerServices.Commands;
using BusinessLogic.Library.Repositories.LoggerServices.Queries;
using BusinessLogic.Library.Repositories.RoleServices.Commands;
using BusinessLogic.Library.Repositories.RoleServices.Queries;
using BusinessLogic.Library.Repositories.SamanehServices.Commands;
using BusinessLogic.Library.Repositories.SamanehServices.Queries;
using BusinessLogic.Library.Repositories.TaskServices.Commands;
using BusinessLogic.Library.Repositories.TaskServices.Queries;
using BusinessLogic.Library.Repositories.UserServices.Commands;
using BusinessLogic.Library.Repositories.UserServices.Queries;
using BusinessLogic.Library.UnitOfWork;

namespace Infrastrucure.Library.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork() { }

        public IBackupCommandServices IBackupCommandServices => throw new System.NotImplementedException();

        public IBackupQueryServices IBackupQueryServices => throw new System.NotImplementedException();

        public ILoggerQueryServices ILoggerQueryServices => throw new System.NotImplementedException();

        public ILoggerCommandServices ILoggerCommandServices => throw new System.NotImplementedException();

        public IRoleCommandServices IRoleCommandServices => throw new System.NotImplementedException();

        public IRoleQueryServices IRoleQueryServices => throw new System.NotImplementedException();

        public ISamanehCommandService ISamanehCommandService => throw new System.NotImplementedException();

        public ISamanedQueryService ISamanedQueryService => throw new System.NotImplementedException();

        public ITaskCommandServices ITaskCommandServices => throw new System.NotImplementedException();

        public ITaskQueryServices ITaskQueryServices => throw new System.NotImplementedException();

        public IUserCommandRepository IUserCommandRepository => throw new System.NotImplementedException();

        public IUserRoleCommandServices IUserRoleCommandServices => throw new System.NotImplementedException();

        public IUserQueryServices IUserQueryServices => throw new System.NotImplementedException();

        public IUserRoleQueryServices IUserRoleQueryServices => throw new System.NotImplementedException();
    }
}
