using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Library.Repository.BackupService
{
    public class BackupQueries
    {
        public string ShowAll(string paging)
        {
            return $@"
SELECT  B.ID AS آیدی, 
		B.BackupType AS نوع, 
		B.FileName AS [نام فایل], 
		B.FileAddress AS آدرس, 
		B.Title AS عنوان, 
		B.Description AS توضیحات,
		B.CreateDate AS [تاریخ ثبت], 
		U.DisplayName AS [ذخیره کننده], 
		B.UpdateDate AS [آخرین تاریخ ویرایش], 
		U.DisplayName AS [ویرایش توسط]

FROM    [LOG].BackupLogs B
INNER JOIN SEC.UserRoles UR ON UR.ID = B.CreatedByUserRoleID
INNER JOIN SEC.Users U ON U.ID = UR.UserID
WHERE   
(B.IsDeleted = 0) AND (B.IsActive = 1)
ORDER BY B.ID DESC
{paging}
            ";
        }
    }
}
