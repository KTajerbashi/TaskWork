using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Library.Repository.TaskService
{
    public class TaskQueries
    {
        public string ShowAll(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID 
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) 
AND (BUS.TaskWorks.IsDeleted = 0)
ORDER BY BUS.TaskWorks.CreateDate DESC
{paging}
");
        }
        public string ShowAlphabet(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0)
ORDER BY BUS.TaskWorks.Title 
{paging}
");
        }
        public string ShowPassed(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsPassed = 1)
ORDER BY BUS.TaskWorks.CreateDate DESC  
{paging}
");
        }
        public string ShowNotPassed(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsPassed = 0)
ORDER BY BUS.TaskWorks.CreateDate DESC 
{paging}
");
        }
        public string ShowSearchDate(string word)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) 
AND (BUS.TaskWorks.Title LIKE N'%{word}%' OR BUS.TaskWorks.Description LIKE N'%{word}%')
ORDER BY BUS.TaskWorks.CreateDate DESC 
OFFSET {0} ROWS FETCH NEXT {40} ROWS ONLY
");
        }
        public string ShowDeliver(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsDeliver = 1)
ORDER BY BUS.TaskWorks.CreateDate DESC 
{paging}
");
        }
        public string ShowImportant(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0)
ORDER BY BUS.TaskWorks.ImportanceType DESC 
{paging}
");
        }
        public string ShowNotDeliver(string paging)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
(BUS.TaskWorks.IsActive = 1) AND (BUS.TaskWorks.IsDeleted = 0) AND (BUS.TaskWorks.IsDeliver = 0)
ORDER BY BUS.TaskWorks.CreateDate DESC 
{paging}
");
        }
         public string ShowFDateT(string fromDate,string toDate)
        {
            return ($@"
SELECT
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS عنوان,
	BUS.TaskWorks.Description AS توضیحات,
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END N'نوع',
	CASE BUS.TaskWorks.ImportanceType
	WHEN 0 THEN N'ضعیف'
	WHEN 1 THEN N'متوسط'
	WHEN 2 THEN N'بالا'
	WHEN 3 THEN N'فوری'
	WHEN 4 THEN N'خیلی فوری'
	END N'الویت',
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'پاس شده؟',
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'خیر'
	WHEN 1 THEN N'بلی'
	END N'تحویل شده؟',
	BUS.TaskWorks.Answer AS پاسخ,
	BUS.Samanehs.Title AS سامانه,
	SEC.Users.DisplayName AS [نام کاربر],
	SEC.Roles.Description AS نقش,
	format(BUS.TaskWorks.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
	format(BUS.TaskWorks.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM BUS.TaskWorks 
INNER JOIN BUS.Samanehs ON BUS.TaskWorks.SamanaID = BUS.Samanehs.ID
INNER JOIN SEC.Users ON BUS.TaskWorks.UserID = SEC.Users.ID 
INNER JOIN SEC.Roles ON BUS.TaskWorks.RoleId = SEC.Roles.ID
WHERE 
	(BUS.TaskWorks.IsActive = 1) 
AND (BUS.TaskWorks.IsDeleted = 0)
AND (BUS.TaskWorks.CreateDate > N'{fromDate}' AND BUS.TaskWorks.CreateDate < N'{toDate}')
ORDER BY BUS.TaskWorks.CreateDate DESC 
");
        }

    }
}
