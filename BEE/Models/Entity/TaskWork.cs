using BEE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE.Models.Entity
{
    public class TaskWork : GeneralEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        [DefaultValue(false)]
        public bool IsPassed { get; set; }

        [DefaultValue(false)]
        public bool IsDeliver { get; set; }


        [ForeignKey("Application")]
        public long ApplicationID { get; set; }
        public Application Application { get; set; }
    }
}
