using BusinessLogic.Library;
using Domain.Library.KeyValues;
using Domain.Model;
using Infrastructure.Library.DbContextData;
using Infrastrucure.Library.BaseService;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastrucure.Library.Repository.UserService
{
    public class UserService : BaseService<User, DatabaseContext>
    {
        public Result<User> GetByUserName(string username)
        {
            return new Result<User>
            {
                Data = _context.Users.Where(x => x.Username == username).FirstOrDefault(),
                Message = "اطلاعات واکشی شد",
                Success = true
            };
        }
        public Result<User> IsExist(string username, string password)
        {
            return new Result<User>
            {
                Data = _context.Users.Where(x => (x.Username == username && x.Password == password) && !x.IsDeleted && x.IsActive).Single(),
                Message = "اطلاعات واکشی شد",
                Success = true
            };
        }
        public Result<User> IsMatchAny(User entity)
        {
            var res = _context.Users.Where(x => (x.Username == entity.Username && x.Email == entity.Email && x.Phone == entity.Phone) && !x.IsDeleted && x.IsActive).FirstOrDefault();
            if (res == null)
            {
                return new Result<User>
                {
                    Data = res,
                    Message = "اطلاعات واکشی شد",
                    Success = true
                };
            }
            return new Result<User>
            {
                Data = null,
                Message = "اطلاعات واکشی نشد",
                Success = false
            };

        }
        public Result<User> InsertWithRole(User entity, Role role)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            var ur = new UserRole
            {
                RoleID = role.ID,
                UserID = entity.ID,
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                Description = entity.Description,
                Title = entity.Title,
            };
            _context.UserRoles.Add(ur);
            return new Result<User>
            {
                Data = entity,
                Success = true,
                Message = ""
            };
        }
        public Result<User> UpdateWithRole(User entity, Role role)
        {
            _context.Users.AddOrUpdate(entity);
            var ur = new UserRole
            {
                RoleID = role.ID,
                UserID = entity.ID,
                CreateDate = DateTime.Now,
                IsActive = true,
                IsDeleted = false,
                Description = entity.Description,
                Title = entity.Title,
            };
            _context.UserRoles.Add(ur);
            return new Result<User>
            {
                Data = entity,
                Success = true,
                Message = ""
            };
        }
        public Result<User> Recovery(User entity)
        {
            var res = _context.Users.Where(x => x.Username == entity.Username && x.Email == entity.Email && x.Phone == entity.Phone).FirstOrDefault();
            if (res == null)
            {
                return new Result<User>
                {
                    Data = entity,
                    Success = false,
                    Message = "اطلاعات وجود ندارد"
                };
            }
            return new Result<User>
            {
                Data = res,
                Success = true,
                Message = "اطلاعات ویرایش شد"
            };
        }
        public async Task<Result<User>> UpdateRecoveryPass(User entity)
        {
            await base.Update(entity);
            return new Result<User>
            {
                Message = "اطلاعات با موفقیت ویرایش شد",
                Success = true,
                Data = entity,
            };
        }
        public Result<List<ComboboxItem<long>>> ReadKeyValue()
        {
            var res = _context.Users.Select(x => new ComboboxItem<long>
            {
                Text = x.DisplayName,
                Value = x.ID
            }).ToList();
            return new Result<List<ComboboxItem<long>>>
            {
                Data = res,
                Success = true,
                Message = ""
            };
        }

    }
}
