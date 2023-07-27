using Domain.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("TaskWorks", Schema = "BUS")]
    public class TaskWork : GeneralEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [DefaultValue(false)]
        public bool IsPassed { get; set; }

        [DefaultValue(false)]
        public bool IsDeliver { get; set; }


        [ForeignKey(nameof(Samaneh))]
        public long SamanaID { get; set; }
        public Samaneh Samaneh { get; set; }
    }
}
