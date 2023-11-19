using Domain.Library.Models.Entity;
using Domain.Model;
using System;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Library.DatabaseService
{
    public interface IDatabaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<TaskWork> Tasks { get; set; }
        DbSet<TaskWorkHistory> TaskWorkHistories { get; set; }
        DbSet<Samaneh> Samanehs { get; set; }
        DbSet<Backup> Backups { get; set; }
        DbSet<Logger> Loggers { get; set; }
        DbSet<Privilege> Privileges { get; set; }
        DbSet<RoadmapLesson> RoadmapLessons { get; set; }
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
