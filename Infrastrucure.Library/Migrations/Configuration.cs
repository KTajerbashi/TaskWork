﻿namespace Infrastrucure.Library.Migrations
{
    using Domain.Model;
    using Infrastructure.Library.DatabaseContext.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.Library.DatabaseContext.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infrastructure.Library.DatabaseContext.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.
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
            var Users =
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
                };
            if (context.Users.Count() == 0)
            {
                context.Users.Add(Users);
            }
            if (context.Roles.Count() == 0)
            {
                context.Roles.AddRange(Roles);
            }
            base.Seed(context);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
