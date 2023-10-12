using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum TaskType : byte
    {
        
        [Description("تسک توسعه")]
        middle = 1,
        [Description("تسک پشتیبانی")]
        important = 2,
        [Description("سمپا")]
        very_important = 3,
    }
}
