﻿namespace Infrastrucure.Library.Migrations
{
    using DAL.DatabaseContext;
    using Domain.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.DatabaseContext.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Samanehs.AddOrUpdate(c => c.ID,
                new Samaneh() { ID = 1, Title = "سامانه BPMS", Name = nameof(SamanaSeed.BPMS), Description = "اطلاعات سامانه میباشد", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now },
                new Samaneh() { ID = 2, Title = "سامانه کمیسیون", Name = nameof(SamanaSeed.Commission), Description = "اطلاعات سامانه میباشد", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now },
                new Samaneh() { ID = 3, Title = "سامانه سراج", Name = nameof(SamanaSeed.Seraj), Description = "اطلاعات سامانه میباشد", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now },
                new Samaneh() { ID = 4, Title = "سامانه املاک", Name = nameof(SamanaSeed.Estate), Description = "اطلاعات سامانه میباشد", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now }
                );
            context.Roles.AddOrUpdate(c => c.ID,
                new Role() { ID = 1, Title = nameof(UserRolesSeed.Admin), Description = "ادمین", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now },
                new Role() { ID = 2, Title = nameof(UserRolesSeed.Operator), Description = "اپراتور", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now },
                new Role() { ID = 3, Title = nameof(UserRolesSeed.User), Description = "کاربر", IsActive = true, IsDeleted = false, CreatedByUserRoleID = 1, CreateDate = DateTime.Now }
                );
        }
    }
}
