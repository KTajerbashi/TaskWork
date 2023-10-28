using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Models.Entity
{
    [Table("RoadmapLessons", Schema = "BUS")]
    public class RoadmapLesson : GeneralEntity
    {
        [ForeignKey(nameof(RoadmapLessonChild))]
        public long? ParentId { get; set; }
        public RoadmapLesson RoadmapLessonChild { get; set; }

        public bool IsStarted { get; set; }
        public bool InProgress { get; set; }
        public bool IsFinishid { get; set; }
        public bool IsImplemented { get; set; }
        public bool HasFile { get; set; }

    }
}
