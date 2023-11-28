namespace Infrastrucure.Library.Repository.SamanehService
{
    public class SamanehQueries
    {
        public string Count()
        {
            return ($@"
				SELECT 
					COUNT(*) AS Count
				FROM BUS.Samanehs
				WHERE (IsDeleted = 0)
				");
        }
        public string ShowAll(string paging)
        {
            return ($@"
				SELECT ID AS [آیدی],Name AS نام, Title AS عنوان, Description AS توضیحات,
				CASE  WHEN IsActive = 0 THEN N'غیر فعال'
						  ELSE N'فعال'
						  END [وضعیت ؟], 
				format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
				FROM BUS.Samanehs
				WHERE (IsDeleted = 0)
				ORDER BY ID DESC
				{paging}");
        }
        public string ShowFDateT(string from, string to)
        {
            return ($@"
				SELECT ID AS [آیدی],Name AS نام, Title AS عنوان, Description AS توضیحات,
					CASE  WHEN IsActive = 0 THEN N'غیر فعال'
						  ELSE N'فعال'
						  END [وضعیت ؟], 
				format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], 
				format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
				FROM BUS.Samanehs
				WHERE  (IsDeleted = 0)
				AND (CreateDate > '{from}' AND CreateDate < '{to}')
				ORDER BY ID DESC");
        }
        public string SearchText(string data)
        {
            return ($@"
				SELECT ID AS [آیدی],Name AS نام, Title AS عنوان, Description AS توضیحات,
				CASE  WHEN IsActive = 0 THEN N'غیر فعال'
										  ELSE N'فعال'
										  END [وضعیت ؟], 
				format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت], format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
				FROM BUS.Samanehs
				WHERE  (IsDeleted = 0)
				AND	
(
Name LIKE N'%{data}%' OR
Title LIKE N'%{data}%' OR
Description LIKE N'%{data}%'

)
				ORDER BY ID DESC
				");
        }

    }
}
