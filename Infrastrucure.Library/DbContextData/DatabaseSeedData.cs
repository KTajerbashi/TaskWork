
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
                    Title = RolesSeed.Admin,
                    CreateDate = DateTime.Now,
                    Description = "ادمین",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByUserRoleID = 0,
                },
                 new Role
                {
                    ID=2,
                    Title = RolesSeed.Operator,
                    CreateDate = DateTime.Now,
                    Description = "کارشناس",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByUserRoleID = 0,
                },
                 new Role
                {
                    ID=3,
                    Title = RolesSeed.User,
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
                    Name = RolesSeed.Admin,
                    Family = RolesSeed.Admin,
                    Phone = RolesSeed.Admin,
                    Email = RolesSeed.Admin,
                    Password = RolesSeed.Admin,
                    Address = RolesSeed.Admin,
                    DisplayName = RolesSeed.Admin,
                    Description = RolesSeed.Admin,
                    Title = RolesSeed.Admin,
                    Username = RolesSeed.Admin,
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
