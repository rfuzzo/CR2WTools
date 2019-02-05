using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RED.Core;
using RED.CR2W;

namespace RED
{
    public enum HandleType
    {
        PointerHandle,
        SoftHandle
    }

    public sealed class Handle<T> where T : ISerializable
    {
        public HandleType HandleType { get; private set; }

        private T       _instance;

        private CObject _owner;
        private string  _cachedPath;
        private Type    _cachedType;
        private ushort  _flags;

        public T Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                if(value is CObject obj)
                {
                    obj.SetParent(_owner);
                }
                _instance = value;
            }
        }
        public bool HasValue => Instance != null;
        public Type HandleOf => typeof(T);
        public Type InstanceType
        {
            get
            {
                if(HasValue)
                {
                    _cachedType = Instance.GetType();
                }
                return _cachedType;
            }
        }
        public string DepotPath
        {
            get
            {
                if (HandleType == HandleType.PointerHandle)
                    return null;

                if (Instance is CResource res)
                {
                    _cachedPath = res.GetPath();
                }
                return _cachedPath;
            }
            set
            {
                if (HandleType == HandleType.PointerHandle)
                    return;

                if (Instance != null)
                    return;

                _cachedPath = value;
            }
        }
        public ushort Flags
        {
            get => _flags;
            set => _flags = value;
        }
    }
}