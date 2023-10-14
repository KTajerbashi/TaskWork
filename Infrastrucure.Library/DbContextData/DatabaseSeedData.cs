
using Domain.Model;
using Infrastructure.Library.DatabaseContext.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Infrastructure.Library.DatabaseContext
{
    public class DatabaseSeedData : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var Roles = new List<Role>
            {
                 new Role
                {
                    ID=1,
                    Title = RolesSeed.ADMIN,
                    CreateDate = DateTime.Now,
                    Description = "ادمین",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByUserRoleID = 0,
                },
                 new Role
                {
                    ID=2,
                    Title = RolesSeed.OPERATOR,
                    CreateDate = DateTime.Now,
                    Description = "کارشناس",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByUserRoleID = 0,
                },
                 new Role
                {
                    ID=3,
                    Title = RolesSeed.USER,
                    CreateDate = DateTime.Now,
                    Description = "کاربر",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByUserRoleID = 0,
                },
            };
            var Users = new List<User>
            {
                new User
                {
                    ID = 0,
                    Name = RolesSeed.ADMIN,
                    Family = RolesSeed.ADMIN,
                    Phone = RolesSeed.ADMIN,
                    Email = RolesSeed.ADMIN,
                    Password = RolesSeed.ADMIN,
                    Address = RolesSeed.ADMIN,
                    DisplayName = RolesSeed.ADMIN,
                    Description = RolesSeed.ADMIN,
                    Title = RolesSeed.ADMIN,
                    Username = RolesSeed.ADMIN,
                    IsActive = true,
                    IsDeleted = false,
                    CreateDate = DateTime.Now,
                    CreatedByUserRoleID = 0,
                    UpdateBy = 0,
                    UpdateDate = DateTime.Now,
                },
            };
            Roles.ForEach(x => context.Roles.Add(x));
            Users.ForEach(x => context.Users.Add(x));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
