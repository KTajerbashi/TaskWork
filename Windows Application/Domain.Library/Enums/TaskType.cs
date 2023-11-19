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
    public enum BackupType : byte
    {
        [Description("پشتیبان گیری")]
        Backup = 1,
        [Description("بازگردانی")]
        Restore = 2,
    }
    public enum TaskActionType : byte
    {
        [Description("پشتیبان گیری")]
        Create = 1,
        [Description("ویرایش")]
        Update = 2,
        [Description("پاس")]
        Passed = 3,
        [Description("لغو")]
        Canceled = 4,
        [Description("تحویل")]
        Delivered = 5,
        [Description("حذف")]
        Deleted = 6,
        [Description("زمان اضافه")]
        UpdateTime = 7,

    }
}
