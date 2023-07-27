﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BaseDTO
{
    public interface IBaseDTO
    {
    }
    public abstract class IBaseDTO<T>
    {
        public T ID { get; set; }
    }
    public abstract class BaseDTO : IBaseDTO<long>
    {
        public DateTime CreateDate { get; set; }
        public long CreateBy { get; set; }

        public DateTime DeleteDate { get; set; }
        public long DeleteBy { get; set; }

        public DateTime UpdateDate { get; set; }
        public long UpdateBy { get; set; }
    }
}