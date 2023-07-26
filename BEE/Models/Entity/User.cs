using BEE.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEE.Models.Entity
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

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
