namespace Infrastrucure.Library.DatabaseService
{
    using Domain.Model;
    using Infrastructure.Library.DatabaseContext;
    using Infrastructure.Library.DatabaseContext.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = false;
    //    }

    //    protected override void Seed(Infrastructure.Library.DatabaseContext.DatabaseContext context)
    //    {
    //        //  This method will be called after migrating to the latest version.
    //        var Roles = new List<Role>
    //        {
    //             new Role
    //            {
    //                ID=1,
    //                Title = nameof(RolesSeed.ADMIN),
    //                CreateDate = DateTime.Now,
    //                Description = "ادمین",
    //                IsActive = true,
    //                IsDeleted = false,
    //                CreatedByUserRoleID = 0,
    //            },
    //             new Role
    //            {
    //                ID=2,
    //                Title = nameof(RolesSeed.OPERATOR),
    //                CreateDate = DateTime.Now,
    //                Description = "کارشناس",
    //                IsActive = true,
    //                IsDeleted = false,
    //                CreatedByUserRoleID = 0,
    //            },
    //             new Role
    //            {
    //                ID=3,
    //                Title = nameof(RolesSeed.USER),
    //                CreateDate = DateTime.Now,
    //                Description = "کاربر",
    //                IsActive = true,
    //                IsDeleted = false,
    //                CreatedByUserRoleID = 0,
    //            },
    //        };
    //        var User =
    //            new User
    //            {
    //                ID = 0,
    //                Name = nameof(RolesSeed.ADMIN),
    //                Family = nameof(RolesSeed.ADMIN),
    //                Phone = nameof(RolesSeed.ADMIN),
    //                Email = nameof(RolesSeed.ADMIN),
    //                Password = nameof(RolesSeed.ADMIN),
    //                Address = nameof(RolesSeed.ADMIN),
    //                DisplayName = RolesSeed.ADMIN,
    //                Description = RolesSeed.ADMIN,
    //                Title = RolesSeed.ADMIN,
    //                Username = nameof(RolesSeed.ADMIN),
    //                IsActive = true,
    //                IsDeleted = false,
    //                CreateDate = DateTime.Now,
    //                CreatedByUserRoleID = 0,
    //                UpdateBy = 0,
    //                UpdateDate = DateTime.Now,
    //            };
    //        var UserRole =
    //            new UserRole
    //            {
    //                ID = 0,
    //                RoleID=1,
    //                Title = nameof(RolesSeed.ADMIN),
    //                UserID = 0,
    //                Description = RolesSeed.ADMIN,
    //                IsActive = true,
    //                IsDeleted = false,
    //                CreateDate = DateTime.Now,
    //                CreatedByUserRoleID = 0,
    //                UpdateBy = 0,
    //                UpdateDate = DateTime.Now,
    //            };
    //        if (context.Users.Count() == 0)
    //        {
    //            context.Users.Add(User);
    //        }
    //        if (context.Roles.Count() == 0)
    //        {
    //            context.Roles.AddRange(Roles);
    //        }
    //        if (context.UserRoles.Count() == 0)
    //        {
    //            context.UserRoles.Add(UserRole);
    //        }
    //        base.Seed(context);
    //        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
    //        //  to avoid creating duplicate seed data.
    //    }
    //}
}