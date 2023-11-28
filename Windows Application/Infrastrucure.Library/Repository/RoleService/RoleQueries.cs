using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Library.Repository.RoleService
{
    public class RoleQueries
    {

        public string Count()
        {
            return ($@"
SELECT
	COUNT(*) AS [Count]
FROM SEC.Roles 
WHERE (IsDeleted = 0) 
");
        }
        public string ShowAll(string paging)
        {
            return ($@"
SELECT
	ID AS آیدی, Title AS عنوان,
	[Key] AS کلید, Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش],
    CASE IsActive
        WHEN 1 THEN N'فعال'
        WHEN 0 THEN N'غیر فعال'
    END AS [وضعیت]
FROM SEC.Roles 
WHERE (IsDeleted = 0) 
ORDER BY ID DESC 
{paging}
");
        }
        public string SearchData(string data)
        {
            return ($@"
SELECT
	ID AS آیدی, Title AS عنوان,
	[Key] AS کلید, Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش],
    CASE IsActive
        WHEN 1 THEN N'فعال'
        WHEN 0 THEN N'غیر فعال'
    END AS [وضعیت]
FROM SEC.Roles
WHERE (IsDeleted = 0) 
AND ([Key] LIKE N'%{data}%' OR Title LIKE N'%{data}%') 
ORDER BY ID DESC 
");
        }

        public string ShowAllDisActives(string paging)
        {
            return ($@"
SELECT
	ID AS آیدی, Title AS عنوان,
	[Key] AS کلید, Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش],
    CASE IsActive
        WHEN 1 THEN N'فعال'
        WHEN 0 THEN N'غیر فعال'
    END AS [وضعیت]
FROM SEC.Roles 
WHERE (IsDeleted = 0)  AND IsActive = 0
ORDER BY ID DESC 
{paging}
");
        }

        public string ShowAllActives(string paging)
        {
            return ($@"
SELECT
	ID AS آیدی, Title AS عنوان,
	[Key] AS کلید, Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش],
    CASE IsActive
        WHEN 1 THEN N'فعال'
        WHEN 0 THEN N'غیر فعال'
    END AS [وضعیت]
FROM SEC.Roles 
WHERE (IsDeleted = 0) AND IsActive = 1
ORDER BY ID DESC 
{paging}
");
        }


    }
}
