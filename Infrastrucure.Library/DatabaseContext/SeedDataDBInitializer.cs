using DAL.DatabaseContext;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Infrastrucure.Library
{
    public class SeedDataDBInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var user = new List<User>
        {
            new User {
                ID = 1,
                Name = "ADMIN",
                Family = "ADMIN",
                Email = "ADMIN@Adm.comSystem",
                Address = "First Standard",
                DisplayName = "ADMIN",
                CreateDate = DateTime.Now,
                CreatedByUserRoleID = 0,
                Description = "ADMIN",
                IsActive = true,
                IsDeleted = false,
                Phone = "ADMIN",
                Title = "ADMIN",
            },
        };
            user.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        base.Seed(context);
        }
        
    }
}
