using Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Samanehs", Schema = "BUS")]
    public class Samaneh : GeneralEntity
    {
        public string Name { get; set; }

        public ICollection<TaskWork> TaskWorks { get; set; }
    }
}
