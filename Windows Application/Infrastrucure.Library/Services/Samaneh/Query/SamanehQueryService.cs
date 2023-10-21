using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;

namespace Infrastructure.Library.Services
{
    public class SamanehQueryService : BaseService<Samaneh,DatabaseContext>
    {
        public SamanehQueryService(DatabaseContext context) : base(context)
        {
        }

        public string ShowAll(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
ORDER BY BUS.TaskWorks.ID DESC
{paging}
            ";
        }
        public string ShowFDateT(string from, string to)
        {


            return ($@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.CreateDate > '{from}' AND BUS.TaskWorks.CreateDate < '{to}')
ORDER BY BUS.TaskWorks.ID DESC
");
        }
        public string ShowSearchDate(string data)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.Title LIKE N'%{data}%' OR BUS.TaskWorks.Description LIKE N'%{data}%')
ORDER BY TS.ID DESC
            ";
        }
        public string ShowPassed(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.IsPassed = 1)

ORDER BY BUS.TaskWorks.ID DESC 
{paging}
            ";
        }
        public string ShowNotPassed(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.IsPassed = 0)
ORDER BY BUS.TaskWorks.ID DESC
{paging}
            ";
        }
        public string ShowAlphabet(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
ORDER BY BUS.TaskWorks.Title DESC 
{paging}

            ";
        }
        public string ShowDeliver(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.IsDeliver = 1)
ORDER BY BUS.TaskWorks.ID DESC
{paging}
            ";
        }
        public string ShowNotDeliver(string paging, int UserRole)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.IsDeliver = 0)
ORDER BY BUS.TaskWorks.ID DESC
{paging}

            ";
        }
        public string ShowImportant(string paging)
        {
            return $@"
SELECT 
	BUS.TaskWorks.ID AS آیدی,
	BUS.TaskWorks.Title AS [عنوان تسک],
	BUS.TaskWorks.Description AS [توضیحات تسک],
	CASE BUS.TaskWorks.Type
	WHEN 1 THEN N'توسعه'
	WHEN 2 THEN N'پشتیبانی'
	WHEN 3 THEN N'سمپا'
	END AS نوع,
	CASE BUS.TaskWorks.ImportanceType
	WHEN 1 THEN N'پایین'
	WHEN 2 THEN N'متوسط'
	WHEN 3 THEN N'بالا'
	WHEN 4 THEN N'فوری'
	WHEN 5 THEN N'خیلی فوری'
	END AS الویت,
	BUS.TaskWorks.Answer [پاسخ], 
	CASE BUS.TaskWorks.IsDeliver
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [تحویل شده؟],
	CASE BUS.TaskWorks.IsPassed
	WHEN 0 THEN N'نخیر'
	WHEN 1 THEN N'بلی'
	END AS [پاس شده؟],
	BUS.Samanehs.Name AS [نام سامانه], 
	BUS.Samanehs.Title AS [عنوان سامانه],
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
AND (BUS.TaskWorks.IsDeliver = 1)
ORDER BY BUS.TaskWorks.ImportanceType DESC
{paging}

            ";
        }

    }
}
