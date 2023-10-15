using System;

namespace Domain.Base
{
    public interface IBaseEntity<IKey> : IEntity
    {
        IKey ID { get; set; }


        bool IsDeleted { set; get; }


        DateTime? UpdateDate { get; set; }

        long? UpdateBy { get; set; }
    }
}
