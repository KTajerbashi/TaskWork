using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApplication.Common
{
    public class TaskWorkShowGird
    {
        public string ShowAll(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)

ORDER BY TS.ID DESC
{paging}
            ";
        }
		public string ShowFDateT(string from,string to)
		{
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND (TS.CreateDate > '{from}' AND Ts.CreateDate < '{to}')
ORDER BY TS.ID DESC
            ";
        }

        public string ShowSearchDate(string data)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت', 
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID OR SM.Title LIKE N'%{data}%'
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND (TS.Title LIKE N'%{data}%' OR TS.Description LIKE N'%{data}%')
ORDER BY TS.ID DESC
            ";
        }
        public string ShowPassed(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND TS.IsPassed = 1
ORDER BY TS.ID DESC
{paging}
            ";
        }
        public string ShowNotPassed(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND TS.IsPassed = 0
ORDER BY TS.ID DESC
{paging}
            ";
        }
        public string ShowAlphabet(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
ORDER BY TS.Title
{paging}

            ";
        }
        public string ShowDeliver(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND TS.IsDeliver = 1
ORDER BY TS.ID DESC
{paging}

            ";
        }
        public string ShowNotDeliver(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
AND TS.IsDeliver = 0
ORDER BY TS.ID DESC
{paging}

            ";
        }
        public string ShowImportant(string paging)
        {
            return $@"
SELECT 
    TS.ID AS [آیدی],
    TS.Title AS [عنوان تسک],
        CASE TS.ImportanceType WHEN 0 THEN N'کم' WHEN 1 THEN N'متوسط' WHEN 2 THEN N'مهم' WHEN 3 THEN N'خیلی مهم' WHEN 4 THEN N'فوری' ELSE N'نامعلوم' END AS N'الویت',
	TS.Description AS [توضیحات تسک],
	format(TS.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	CASE  WHEN TS.IsPassed = 0 THEN N'نخیر'
		  ELSE N'بلی'
	END [پاس شده؟], 
	CASE WHEN TS.IsDeliver = 0 THEN N'نخیر'
		 ELSE N'بلی'
	END [تحویل شده؟], 
	SM.Title AS [سامانه]
	
FROM 
	BUS.TaskWorks TS
	INNER JOIN BUS.Samanehs SM ON TS.SamanaID = SM.ID
WHERE (TS.IsDeleted = 0 AND TS.IsActive = 1)
ORDER BY TS.ImportanceType DESC
{paging}

            ";
        }
    }
}
 