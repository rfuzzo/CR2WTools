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
    public class Soft<T> : IReferencable where T : CResource
    {
        public string DepotPath { get; set; }
        public ushort Flags     { get; set; }

        public Type GetSoftType()
        {
            return typeof(T);
        }

        public void ParseBytes(CR2WBinaryReader br, uint size)
        {
            var id = br.ReadUInt16();
            var res = br.resources[id];
            if(res.type != typeof(T).Name)
            {
                throw new InvalidOperationException("soft: Type mismatch. Expected {typeof(T).Nam}, but value was read as {res.type}");
            }
            DepotPath = res.path;
            Flags = res.flags;
        }
    }
}