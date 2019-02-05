using System;
using System.IO;
using RED.Core;

namespace RED
{
    /// <summary>
    /// Represent a soft handle to a CResource instance via depoth path.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class Soft<T> where T : CResource, new()
    {
        private T       _instance;
        private ushort  _flags;
        private string  _cachedPath;
        private Type    _cachedType;

        public T Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public bool HasValue => Instance != null;
        public Type SoftType => typeof(T);
        public string DepotPath
        {
            get
            {
                if(Instance != null)
                {
                    _cachedPath = _instance.GetPath();
                }
                return _cachedPath;
            }
            set
            {
                if(Instance == null)
                {
                    _cachedPath = value;
                }
            }
        }
        public Type InstanceType
        {
            get
            {
                if(_instance != null)
                {
                    _cachedType = _instance.GetType();
                }
                return _cachedType;
            }
        }

        public override string ToString()
        {
            return $"[{InstanceType.Name}] {DepotPath}";
        }
    }
}