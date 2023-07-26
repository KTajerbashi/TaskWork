using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEE.Entities
{
    public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [Description("کلید")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey ID { get; set; }

        [Description("فعال بودن")]
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [Description("حذف شده")]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        [Description("آخرین تاریخ و زمان ویرایش")]
        public DateTime? UpdateDate { get; set; }

        [Description("آخرین کاربر ویرایش کننده")]
        public long? UpdateBy { get; set; }
        public DateTime CreateDate { set; get; }
        public TKey CreatedByUserRoleID { set; get; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {
    }
}
