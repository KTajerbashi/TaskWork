using BEE.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEE.Models.Entity
{
    [Table("Roles", Schema = "SEC")]
    public class Role : GeneralEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
