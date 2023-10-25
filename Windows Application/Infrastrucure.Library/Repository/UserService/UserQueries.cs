namespace Infrastrucure.Library.Repository.UserService
{
    public sealed class UserQueries
    {
        public string ShowAll(string paging)
        {
            return $@"
SELECT
	ID AS آیدی,
	Name AS نام,
	Family AS فامیل,
	DisplayName AS [نام کامل],
	Email AS ایمیل,
	Phone AS تلفن,
	Address AS آدرس,
	Username AS [نام کاربری],
	Title AS عنوان,
	Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM SEC.Users
WHERE 
	(IsActive = 1) 
AND (IsDeleted = 0)
ORDER BY ID
{paging}
            ";
        }
        public string SearchResult(string data)
        {
            return $@"
SELECT
	ID AS آیدی,
	Name AS نام,
	Family AS فامیل,
	DisplayName AS [نام کامل],
	Email AS ایمیل,
	Phone AS تلفن,
	Address AS آدرس,
	Username AS [نام کاربری],
	Title AS عنوان,
	Description AS توضیحات,
	format(CreateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [تاریخ ثبت],
	format(UpdateDate,'yyyy/MM/dd hh:mm','fa-ir') AS [آخرین ویرایش]
FROM SEC.Users
WHERE 
(IsDeleted = 0)
AND (Name LIKE N'%{data}%' OR Family LIKE N'%{data}%' OR Email Like N'%{data}%' OR Phone LIKE N'%{data}%')
ORDER BY ID DESC
            ";
        }
	}
}
