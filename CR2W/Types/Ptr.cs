using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    [REDPrimitive]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public struct Ptr<T>
    {
        private T _instance;

        public T Instance => _instance;
        public bool HasValue => _instance != null;
        public Type PointerType => typeof(T);
        public Type InstanceType => _instance?.GetType();
        public uint Index { get; set; }

        public void DeSerialize(IFile file, REDEventArgs e)
        {
            if(typeof(T).IsAssignableFrom(typeof(T)))
            {
                throw new Exception($"{nameof(T)} is not assignable from {nameof(T)}");
            }
            
            



        }
    }
}