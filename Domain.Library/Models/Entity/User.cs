using Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;

namespace Domain.Model
{
    [Table("Users", Schema = "SEC")]
    public class User : GeneralEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<TaskWork> TaskWorks { get; set; }
    }
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
        }
    }
}
