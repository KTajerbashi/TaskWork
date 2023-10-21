using Domain.Library.Models.Entity;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System.Data.SqlClient;
using System;

namespace Infrastructure.Library.Services.LoggerService
{
    public class LoggerCommandServices : BaseService<Logger, DatabaseContext>
    {
        public LoggerCommandServices(DatabaseContext context) : base(context)
        {
        }
        public void Backup(String Path, Backup model)
        {
            var _ctr = "Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;";
            //_ctr = "Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;";
            var des = $"پشتیبان گیری در تاریخ {DateTime.Now} با نقش {log.Description} و کاربر {log.Title} انجام شد";
            try
            {
                SqlConnection connection = new SqlConnection(_ctr);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"BACKUP DATABASE RG_TaskWorkDB TO DISK = '" + Path + @"\BACKUPDB.BAK'";
                command.ExecuteNonQuery();
                command.CommandText = $@"INSERT INTO 
[LOG].[BackupLogs] 
([BackupType], [FileName], [FileAddress], [Title], [Description], [CreateDate], [CreatedByUserRoleID], [IsActive], [IsDeleted], [UpdateDate], [UpdateBy])
VALUES
(2, N'BACKUPDB.BAK', N'{Path}', N'Backup',N'{des}', (SELECT GETDATE()), {log.CreatedByUserRoleID}, 1, 0, (SELECT GETDATE()), {log.UpdateBy})";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                throw;
            }
        }
        public void Restor(String Path, Backup model)
        {
            var _ctr = "Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;";
            //_ctr = "Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;";
            var des = $"پشتیبان گیری در تاریخ {DateTime.Now} با نقش {log.Description} و کاربر {log.Title} انجام شد";
            if (Path.Length != 0)
            {
                SqlConnection connection = new SqlConnection(_ctr);
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "alter database RG_TaskWorkDB set offline with rollback immediate";
                command.ExecuteNonQuery();
                command.CommandText = @" RESTORE DATABASE RG_TaskWorkDB FROM DISK = '" + Path + "' WITH REPLACE";
                command.ExecuteNonQuery();
                command.CommandText = "alter database RG_TaskWorkDB set online";
                command.ExecuteNonQuery();
                command.CommandText = $@"INSERT INTO 
[LOG].[BackupLogs] 
([BackupType], [FileName], [FileAddress], [Title], [Description], [CreateDate], [CreatedByUserRoleID], [IsActive], [IsDeleted], [UpdateDate], [UpdateBy])
VALUES
(2, N'BACKUPDB.BAK', N'{Path}', N'Backup',N'{des}', (SELECT GETDATE()), {log.CreatedByUserRoleID}, 1, 0, (SELECT GETDATE()), {log.UpdateBy})";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

    }
}
