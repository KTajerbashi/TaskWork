using BusinessLogic.Library.DatabaseService;
using Domain.Library.Models.Entity;
using Domain.Model;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Library.DbContextData
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        //public DatabaseContext() : base("Data Source=172.20.1.20\\DEV;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=soft157703ware;")
        public DatabaseContext() : base("Data Source=TAJERBASHI;Initial Catalog=RG_TaskWorkDB; User ID=sa; Password=123123;")
        {
        }

        public DbSet<TaskWork> Tasks { get; set; }
        public DbSet<Samaneh> Samanehs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Backup> Backups { get; set; }
        public DbSet<Logger> Loggers { get; set; }
        public int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        public Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }


    }
}

