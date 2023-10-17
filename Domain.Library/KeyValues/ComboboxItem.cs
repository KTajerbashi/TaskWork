﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Library.KeyValues
{
    public class ComboboxItem<T>
    {
        public string Text { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
