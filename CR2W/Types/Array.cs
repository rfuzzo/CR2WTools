using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CR2W.Types
{
    



    [TypeConverter(typeof(ListConverter))]
    public class Array<T> : List<T>
    {
        public Type ArrayOf
        {
            get
            {
                return typeof(T);
            }
        }
    }
}
