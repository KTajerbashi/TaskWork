using Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Roles", Schema = "SEC")]
    public class Role : GeneralEntity
    {
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<TaskWork> TaskWorks { get; set; }
    }
}
