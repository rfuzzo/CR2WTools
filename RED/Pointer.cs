using System;
using System.IO;
using System.Reflection;
using RED.Core;
using RED.CR2W;
using RED.IO;

namespace RED
{
    /// <summary>
    /// Represents a strongly typed pointer to another <see cref="IExportable"/> instance.
    /// </summary>
    /// <typeparam name="T"><see cref="IExportable"/> instance type.</typeparam>
    public sealed class Pointer<T>
    {
        private CObject _owner;
        private T       _instance;

        public T Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
                if(_instance is CObject obj)
                {
                    obj.SetParent(_owner);
                }
            }
        }
        public bool HasValue => Instance != null;
        public Type PointerType => typeof(T);
        public Type InstanceType => Instance?.GetType();

        public static implicit operator Pointer<T>(T value)
        {
            return new Pointer<T>(value);
        }
        public static implicit operator T(Pointer<T> value)
        {
            return value.Instance;
        }

        public Pointer()
        {

        }
        public Pointer(T instance)
        {
            Instance = instance;
        }

    }
}