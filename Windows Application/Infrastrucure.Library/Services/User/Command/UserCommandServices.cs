using BusinessLogic.Library.Extentions;
using Domain.Model;
using System.Data.Entity.Migrations;
using System.Linq;
using System;
using Infrastrucure.Library.BaseService;
using Infrastructure.Library.DbContextData;
using BusinessLogic.Library;

namespace Infrastructure.Library.Services
{
    public class UserCommandServices : BaseService<User,DatabaseContext>
    {
        public UserCommandServices(DatabaseContext context) : base(context)
        {
        }

        public Result<User> UpdateRecoveryPass(User user)
        {
            var Nuser = _context.Users.Where(x => x.Username == user.Username).FirstOrDefault();
            Nuser.Password = PasswordHasher.HashPassword(user.Password);
            Nuser.Salt = CryptoPassword.GeneratePassword(user.Password).Salt;
            Nuser.Hash = CryptoPassword.GeneratePassword(user.Password).Hash;
            Nuser.UpdateDate = DateTime.Now;
            Nuser.UpdateBy = user.UpdateBy;
            _context.Users.AddOrUpdate(Nuser);
            _context.SaveChanges();
            return new Result<User>
            {
                Data = user,
                Success = true,
                Message = "با موفقیت ویرایش شد"
            };
        }
        public Result<User> InsertWithRole(User user, Role role)
        {
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
