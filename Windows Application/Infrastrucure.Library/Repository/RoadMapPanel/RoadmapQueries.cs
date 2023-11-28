namespace Infrastrucure.Library.Repository.RoadMapPanel
{
    public class RoadmapQueries
    {

        public string Count()
        {
            return $@"
SELECT
COUNT(*)
FROM 
	BUS.RoadmapLessons M
WHERE
	(M.IsActive = 1)
AND (M.IsDeleted = 0)
            ";
        }

        public string ShowAll(string paging)
        {
            return $@"
SELECT
	M.ID AS آیدی,
	(SELECT Title FROM BUS.RoadmapLessons WHERE ID = M.ParentID) AS والد,
	M.Title AS عنوان,
	M.Description AS توضیحات,
	CASE M.IsStarted 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [شروع شده],
	CASE M.InProgress
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [در حال جریان],
	CASE M.IsFinishid 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [تمام شده],
	CASE M.IsImplemented 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [پیاده سازی شده],
	CASE M.HasFile 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [فایل دارد؟], 
format(M.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
format(M.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM 
	BUS.RoadmapLessons M
WHERE
	(M.IsActive = 1)
AND (M.IsDeleted = 0)
ORDER BY M.ID DESC

{paging}
            ";
        }


        public string SearchData(string data)
        {
            return $@"
SELECT
	M.ID AS آیدی,
	(SELECT Title FROM BUS.RoadmapLessons WHERE ID = M.ParentID) AS والد,
	M.Title AS عنوان,
	M.Description AS توضیحات,
	CASE M.IsStarted 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [شروع شده],
	CASE M.InProgress
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [در حال جریان],
	CASE M.IsFinishid 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [تمام شده],
	CASE M.IsImplemented 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [پیاده سازی شده],
	CASE M.HasFile 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS [فایل دارد؟], 
format(M.CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
format(M.UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM 
	BUS.RoadmapLessons M
WHERE
	(M.IsActive = 1)
AND (M.IsDeleted = 0)
AND (M.Title LIKE N'%{data}%' OR M.Description LIKE N'%{data}%')
ORDER BY M.ID DESC
            ";
        }

    }
}
