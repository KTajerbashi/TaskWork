using BusinessLogic.Library;
using BusinessLogic.Library.Extentions;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastructure.Library.Models;
using Infrastrucure.Library.BaseService;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Library.Services
{
    public class UserQueryServices : BaseService<User,DatabaseContext>
    {
        public UserQueryServices(DatabaseContext context) : base(context)
        {
        }

        public Result<User> GetByUserName(string username)
        {
            return new Result<User>
            {
                Data = _context.Users.Include("UserRoles").Single(x => x.Username == username),
                Success = true,
                Message = "اطلاعات کاربر به درستی واکشی شد"
            };
        }
        public Result<List<ComboboxItem<long>>> ReadKeyValue()
        {
            var item = _context.Users.Where(x => x.IsActive && !x.IsDeleted).Select(x => new ComboboxItem<long>
            {
                Text = x.Name + " " + x.Family,
                Value = x.ID
            }).ToList();
            return new Result<List<ComboboxItem<long>>>
            {
                Data = item.ToList(),
                Success = true,
                Message = ""
            };
        }
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
            if (username == nameof(RolesSeed.ADMIN) && pass == nameof(RolesSeed.ADMIN))
            {
                if (_context.Users.Any(x => x.Username == nameof(RolesSeed.ADMIN) && x.Password == nameof(RolesSeed.ADMIN) && !x.IsDeleted && x.IsActive))
                {
                    return new Result<User>()
                    {
                        Data = new User
                        {
                            Username = username,
                        },
                        Success = true,
                        Message = "ورود اولیه با موفقیت"
                    };
                }
                else
                {
                    return new Result<User>()
                    {
                        Data = null,
                        Success = false,
                        Message = "اطلاعات معتبر نیست"
                    };
                }
            }
            var use = _context.Users.Where(x => x.Username ==  username.ToLower() && !x.IsDeleted && x.IsActive).FirstOrDefault();
            if (use == null)
            {
                return new Result<User>()
                {
                    Data = null,
                    Success = false,
                    Message = "کاربر مورد نظر یافت نشد"
                };

            }
            if (PasswordHasher.VerifyPassword(pass, use.Password) || CryptoPassword.IsLogin(username, pass))
            {
                return new Result<User>()
                {
                    Data = use,
                    Success = true,
                    Message = "کابر مورد نظر با موفقیت پیدا شد"
                };
            }
            return new Result<User>()
            {
                Data = null,
                Success = false,
                Message = "کاربر مورد نظر یافت نشد"
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
                    Message = "نام کاربری یا ایمیل یا شماره تلفن تکراری است"
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
        public Result<User> Recovery(User user)
        {
            var search = _context.Users.Where(x =>
            !x.IsDeleted &&
            x.IsActive &&
            x.Name == user.Name &&
            x.Family == user.Family &&
            x.Phone == user.Phone &&
            x.Email == user.Email &&
            x.Username == user.Username
            ).FirstOrDefault();
            if (search == null)
            {
                return new Result<User>
                {
                    Data = search,
                    Success = false,
                    Message = "اطلاعاتی وجود ندارد"
                };
            }
            return new Result<User>
            {
                Data = search,
                Success = true,
                Message = "با موفقیت دریافت شد"
            };
        }


    }
}
