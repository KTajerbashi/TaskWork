using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Base
{
    public abstract class GeneralEntity<Tkey> : BaseEntity
    {
        /// <summary>
        /// عنوان
        /// </summary>
        [Description("عنوان")]
        [StringLength(200, ErrorMessage = "برای عنوان حداکثر {1} کاراکتر مجاز میباشد")]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        [Description("توضیحات")]
        //[StringLength(500, ErrorMessage = "برای توضیحات حداکثر {1} کاراکتر مجاز میباشد")]
        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
    public abstract class GeneralEntity : GeneralEntity<long>
    {
    }
}
