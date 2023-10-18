using Domain.Library.Models.Entity;
using Domain.Model;
using System.Data.Entity;

namespace Infrastructure.Library.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;")
        //public DatabaseContext() : base("Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;")
        {
        }

        public DbSet<TaskWork> Tasks { get; set; }
        public DbSet<Samaneh> Samanehs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<BackupLog> BackupLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Samaneh>().HasIndex(c => c.Title).IsUnique();
            modelBuilder.Entity<User>().HasIndex(c => new
            {
                c.Username,
                c.Email,
                c.Phone,
            }).IsUnique();
            modelBuilder.Entity<Role>().HasIndex(c => c.Title).IsUnique();
            modelBuilder.Configurations.Add(new UserMap());
        }

    }
}

