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

namespace BusinessLogic.Library.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBackupCommandServices IBackupCommandServices { get; }
        IBackupQueryServices IBackupQueryServices { get; }
        ILoggerQueryServices ILoggerQueryServices { get; }
        ILoggerCommandServices ILoggerCommandServices { get; }
        IRoleCommandServices IRoleCommandServices { get; }
        IRoleQueryServices IRoleQueryServices { get; }
        ISamanehCommandService ISamanehCommandService { get; }
        ISamanedQueryService ISamanedQueryService { get; }
        ITaskCommandServices ITaskCommandServices { get; }
        ITaskQueryServices ITaskQueryServices { get; }
        IUserCommandRepository IUserCommandRepository { get; }
        IUserRoleCommandServices IUserRoleCommandServices { get; }
        IUserQueryServices IUserQueryServices { get; }
        IUserRoleQueryServices IUserRoleQueryServices { get; }
    }
}
