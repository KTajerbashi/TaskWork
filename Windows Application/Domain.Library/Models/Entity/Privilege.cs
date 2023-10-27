using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Privileges", Schema = "SEC")]
    public class Privilege : GeneralEntity
    {
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public string Panel { get; set; }
        public virtual Role Role { get; set; }
    }
}
