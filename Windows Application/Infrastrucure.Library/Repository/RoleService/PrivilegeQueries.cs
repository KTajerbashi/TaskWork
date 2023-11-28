namespace Infrastrucure.Library.Repository.RoleService
{
    public class PrivilegeQueries
    {
        public string Count()
        {
            return $@"
SELECT       
	Count(*) AS [Count]
FROM SEC.Roles 
INNER JOIN SEC.[Privileges] ON SEC.Roles.ID = SEC.[Privileges].ID
";
        }
        public string ShowAll(string paging)
        {
            return $@"
SELECT       
	SEC.[Privileges].ID AS آیدی,
	SEC.Roles.Title AS نقش,
	SEC.Roles.Description AS توضیحات,
	SEC.Roles.[Key] AS کلید,
	CASE SEC.[Privileges].[Read]
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS خواندن,
	CASE SEC.[Privileges].Write
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS نوشتن,
	CASE SEC.[Privileges].[Update] 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS ویرایش, 
	CASE SEC.[Privileges].[Delete] 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS حذف
FROM SEC.Roles 
INNER JOIN SEC.[Privileges] ON SEC.Roles.ID = SEC.[Privileges].ID
ORDER BY SEC.[Privileges].ID DESC
{paging}
";
        }
        public string SearchData(string data)
        {
            return $@"
SELECT       
	SEC.[Privileges].ID AS آیدی,
	SEC.Roles.Title AS نقش,
	SEC.Roles.Description AS توضیحات,
	SEC.Roles.[Key] AS کلید,
	CASE SEC.[Privileges].[Read]
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS خواندن,
	CASE SEC.[Privileges].Write
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS نوشتن,
	CASE SEC.[Privileges].[Update] 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS ویرایش, 
	CASE SEC.[Privileges].[Delete] 
	WHEN 1 THEN N'بلی'
	WHEN 0 THEN N'خیر'
	END AS حذف
FROM SEC.Roles 
INNER JOIN SEC.[Privileges] ON SEC.Roles.ID = SEC.[Privileges].ID 
WHERE (
SEC.Roles.Title LIKE N'%{data}%' OR
SEC.Roles.[Key] LIKE N'%{data}%'
)
ORDER BY SEC.[Privileges].ID DESC
";
        }
    }
}
