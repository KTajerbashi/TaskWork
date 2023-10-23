using System.ComponentModel;

namespace Domain.Library.Enums
{
    public enum TaskImportanceType : byte
    {
        [Description("ضعیف")]
        low = 0,
        [Description("متوسط")]
        middle = 1,
        [Description("مهم")]
        important = 2,
        [Description("خیلی مهم")]
        very_important = 3,
        [Description("فوری")]
        now = 4,
    }
}
