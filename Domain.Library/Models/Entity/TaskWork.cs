using Domain.Base;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("TaskWork", Schema = "BES")]
    public class TaskWork : GeneralEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime Created { get; set; }

        [DefaultValue(false)]
        public bool IsPassed { get; set; }

        [DefaultValue(false)]
        public bool IsDeliver { get; set; }


        [ForeignKey("Samana")]
        public long SamanaID { get; set; }
        public Samana Samana { get; set; }
    }
}
