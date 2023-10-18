using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("UserRoles", Schema = "SEC")]
    public class UserRole : GeneralEntity
    {
        public long RoleID { get; set; }
        public virtual Role Role { get; set; }


        public long UserID { get; set; }
        public virtual User User { get; set; }

    }
}
