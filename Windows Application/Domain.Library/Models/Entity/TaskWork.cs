using Domain.Base;
using Domain.Library.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("TaskWorks", Schema = "BUS")]
    public class TaskWork : GeneralEntity
    {
        [DefaultValue(false)]
        public bool IsPassed { get; set; }

        [DefaultValue(false)]
        public bool IsDeliver { get; set; }

        public string Answer { get; set; }

        public TaskImportanceType ImportanceType { get; set; }
        public TaskType Type { get; set; }

        [ForeignKey(nameof(Samaneh))]
        public long SamanaID { get; set; }
        public Samaneh Samaneh { get; set; }

        [ForeignKey(nameof(User))]
        public long? UserID { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Role))]
        public long? RoleId { get; set; }
        public Role Role { get; set; }

        public virtual ICollection<TaskWorkHistory> TaskWorkHistories { get; set; }

    }
    [Table("TaskWorkHistories", Schema = "BUS")]
    public class TaskWorkHistory : GeneralEntity
    {
        [ForeignKey("TaskWork")]
        public long TaskWorkId { get; set; }
        public TaskWork TaskWork { get; set; }


        public string Message { get; set; }
        public TaskActionType TaskActionType { get; set; }
        public long FromUser { get; set; }
        public long ToUser { get; set; }
        public long ByUser { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
