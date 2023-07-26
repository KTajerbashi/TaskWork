using BEE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE.Models.Entity
{
    public class Application : GeneralEntity
    {
        public string Name { get; set; }

        public ICollection<TaskWork> TaskWorks { get; set; }
    }
}
