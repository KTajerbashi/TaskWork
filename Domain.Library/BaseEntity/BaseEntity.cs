using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Base
{
    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [Description("کلید")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey ID { get; set; }

        [Description("فعال بودن")]
        public bool IsActive { get; set; } = true;

        [Description("حذف شده")]
        public bool IsDeleted { get; set; } = false;

        [Description("آخرین تاریخ و زمان ویرایش")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        [Description("آخرین کاربر ویرایش کننده")]
        public long? UpdateBy { get; set; }

        public DateTime CreateDate { set; get; } = DateTime.Now;
        public TKey CreatedByUserRoleID { set; get; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {
    }
}
