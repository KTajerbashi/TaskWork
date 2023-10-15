using BusinessLogic.Library.Extentions;
using Domain.Model;
using Infrastructure.Library.DatabaseContext.Models;
using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace BusinessLogic.Library
{
    public class UserService : GenericRepository<User>
    {
        private UserRoleService roleService = new UserRoleService();

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
            var hash = PasswordHash.CreateHash(username);
            var res = _context.Users.Any(x =>   x.Username == username &&
                                                    hash == x.Password &&
                                                    x.IsDeleted == false &&
                                                    x.IsActive == true);
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
        public Result<User> GetByUserName(string username)
        {
            return new Result<User>
            {
                Data = _context.Users.Include("UserRoles").Single(x => x.Username == username),
                Success = true,
                Message = "اطلاعات کاربر به درستی واکشی شد"
            };
        }
        public Result<User> InsertWithRole(User user, Role role)
        {            
            base.Insert(user);
            base.Save();
            var UserRole = new UserRole
            {
                IsActive=true,
                IsDeleted=false,
                CreateDate=DateTime.Now,
                Title=role.Title,
                Description=role.Description,
                CreatedByUserRoleID = user.CreatedByUserRoleID,
                RoleID = role.ID,
                UserID=user.ID,
            };
            roleService.Insert(UserRole);
            roleService.Save();
            return new Result<User>
            {
                Success = true,
                Data = user,
                Message = ""
            };
        }
    }
}
