using BEE.Models.Entity;
using System.Data.Entity;

namespace DAL.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DB")
        {

        }

        public DbSet<TaskWork> Tasks { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
