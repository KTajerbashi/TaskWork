using Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Samana", Schema = "BES")]
    public class Samana : GeneralEntity
    {
        public string Name { get; set; }

        public ICollection<TaskWork> TaskWorks { get; set; }
    }
}
