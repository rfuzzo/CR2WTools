using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Exceptions;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    public class CPtr<T> : IReferencable where T : CObject
    {
        private T _data { get; set; }

        public T GetData()
        {
            return _data;
        }

        public void ParseBytes(BinaryReader br, CR2WParser parser)
        {
            var id = br.ReadInt32();
            var chunk = parser.chunks[id - 1];
            Type resType = Type.GetType($"CR2W.Types.W3.{chunk.type}");

            if (resType == null)
            {
                throw new UnknownObjectTypeException($"[ptr:{typeof(T).Name}] {chunk.type} could not be found");
            }

            if (!resType.IsSubclassOf(typeof(T)))
            {
                throw new UnknownObjectTypeException($"[ptr:{typeof(T).Name}] {chunk.type} is not derived from / does not implement {typeof(T).Name}");
            }

            var _data = (T)Activator.CreateInstance(resType);
            _data.ParseBytes(br, parser);
        }
    }
}