using Domain.Model;
using System.Data.Entity;

namespace DAL.DatabaseContext
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext() : base("Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;")
        public DatabaseContext() : base("Data Source=DESKTOP-9EC7HCL;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;")
        {
        }

        public DbSet<TaskWork> Tasks { get; set; }
        public DbSet<Samaneh> Samanehs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Samana>().HasIndex(c => c.Title).IsUnique();
        }

    }


    public class UserRolesSeed
    {
        public const string Admin = "ادمین";
        public const string Operator = "اپراتور";
        public const string User = "کاربر";
    }

    public class SamanaSeed
    {
        public const string Commission = "سامانه کمیسیون بند 20";
        public const string BPMS = "سامانه BPMS";
        public const string Estate = "سامانه املاک";
        public const string Seraj = "سامانه سراج";
    }
}

