﻿using System;

namespace Domain.Base
{
    public interface IBaseEntity<IKey> : IEntity
    {
        IKey ID { get; set; }
        DateTime CreateDate { set; get; }
        IKey CreatedByUserRoleID { set; get; }


        bool IsDeleted { set; get; }


        DateTime? UpdateDate { get; set; }

        long? UpdateBy { get; set; }
    }
}