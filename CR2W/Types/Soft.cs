using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    [REDPrimitive]
    public struct Soft<T> where T : CResource, new()
    {
        private T _instance;
        private string _cachedPath;

        /// <summary>
        /// Get the l
        /// </summary>
        public string DepotPath
        {
            get
            {
                if(_instance != null)
                {
                    return _instance.GetPath();
                }
                return _cachedPath;
            }
            set
            {
                if(_instance == null)
                {
                    _cachedPath = value;
                }
            }
        }

        public ushort Flags { get; set; }

        public Type SoftOf
        {
            get
            {
                return typeof(T);
            }
        }
    }
}