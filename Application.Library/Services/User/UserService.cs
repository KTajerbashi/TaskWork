using BusinessLogic.Library.Extentions;
using Domain.Model;
using System.Linq;

namespace BusinessLogic.Library
{
    public class UserService : GenericRepository<User>
    {
        public Result<User> IsExit(string username, string pass)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(pass) || string.IsNullOrWhiteSpace(pass))
            {
                return new Result<User>()
                {
                    Data = null,
                    Success = false,
                    Message = "اطلاعات معتبر نیست"
                };
            }
            var res = _context.Users.Any(x =>
            x.Username == username && PasswordHash.ValidatePassword(pass,x.Password) && x.IsDeleted == false && x.IsActive == true
            );
            if (!res)
            {
                return new Result<User>()
                {
                    Data = null,
                    Success = false,
                    Message = "کاربر مورد نظر یافت نشد"
                };
            }
            return new Result<User>()
            {
                Data = _context.Users.Single(x => x.Username == username && PasswordHash.ValidatePassword(pass, x.Password)),
                Success = true,
                Message = "کابر مورد نظر با موفقیت پیدا شد"
            };
        }
        public Result<User> IsMatchAny(User user)
        {
            if (
                string.IsNullOrEmpty(user.Name) ||
                string.IsNullOrWhiteSpace(user.Name) ||
                string.IsNullOrEmpty(user.Family) ||
                string.IsNullOrWhiteSpace(user.Family) ||
                string.IsNullOrEmpty(user.Email) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrEmpty(user.Phone) ||
                string.IsNullOrWhiteSpace(user.Phone) ||
                string.IsNullOrEmpty(user.Password) ||
                string.IsNullOrWhiteSpace(user.Password)
                )
            {
                return new Result<User>
                {
                    Success = false,
                    Data = user,
                    Message = "اطلاعات کامل نیست"
                };
            }
            else
            if (_context.Users.Any(x =>
            x.Username == user.Username || x.Email == user.Email || x.Phone == user.Phone
            ))
            {
                return new Result<User>
                {
                    Success = false,
                    Data = user,
                    Message = "اطلاعات شما تکراری است"
                };
            }
            else
            {
                return new Result<User>
                {
                    Success = true,
                    Data = user,
                    Message = "اطلاعات شما با موفقیت اعتبار سنجی شده است"
                };
            }

        }

    }
}
