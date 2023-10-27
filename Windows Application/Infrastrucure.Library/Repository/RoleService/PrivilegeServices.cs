using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastrucure.Library.Repository.RoleService
{
    public class PrivilegeServices : BaseService<Privilege, DatabaseContext>
    {
        public PrivilegeServices() { }

        public async void InsertWithQuery(Privilege privilege)
        {
            await _context.Database.ExecuteSqlCommandAsync($@"
        INSERT INTO [SEC].[Privileges]
        (
        [Read], [Write], [Update], [Delete],
        [Title], [Description], [CreateDate], 
        [CreatedByUserRoleID], [IsActive], [IsDeleted], 
        [UpdateDate], [UpdateBy], [Panel])
        VALUES 
        (@Read,@Write,@Update,@Delete,N'@Title',N'@Description',GETDATE(),0,1,0,GETDATE(),0,N'@Panel')
        ",
        new
        {
            Read = privilege.Read,
            Write = privilege.Write,
            Update = privilege.Update,
            Delete = privilege.Delete,
            Panel = privilege.Panel,
            Title = privilege.Title,
            Description = privilege.Description,
        });

        }

    }
}
