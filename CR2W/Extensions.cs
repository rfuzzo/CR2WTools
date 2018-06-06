using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types;
using CR2W.Types.W3;
using CR2W.IO;

namespace CR2W
{
    public static class Extensions
    {
        public static string ReadCR2WStringSingle(this BinaryReader br)
        {
            var b = br.ReadByte();
            var nxt = (b & (1 << 6)) != 0;
            var utf = (b & (1 << 7)) == 0;
            int len = b & ((1 << 6) - 1);
            if (nxt)
            {
                len += 64 * br.ReadByte();
            }
            if (utf)
            {
                return Encoding.Unicode.GetString(br.ReadBytes(len * 2));
            }
            return Encoding.ASCII.GetString(br.ReadBytes(len));
        }

        public static List<string> ReadCR2WStringGroup(this BinaryReader br, int size)
        {
            var strs = new List<string>();
            var start = br.BaseStream.Position;
            while (br.BaseStream.Position < start + size)
            {
                var b = br.ReadByte();
                var nxt = (b & (1 << 6)) != 0;
                var utf = (b & (1 << 7)) == 0;
                int len = b & ((1 << 6) - 1);
                if (nxt)
                {
                    len += 64 * br.ReadByte();
                }
                if (utf)
                {
                    strs.Add(Encoding.Unicode.GetString(br.ReadBytes(len * 2)));
                }
                else
                {
                    strs.Add(Encoding.ASCII.GetString(br.ReadBytes(len)));
                }
            }
            return strs;
        }

        public static string ReadString(this BinaryReader br, int length)
        {
            return new string(br.ReadChars(length));
        }

        public static Guid ReadGuid( this BinaryReader br )
        {
            return new Guid(br.ReadBytes(16));
        }
    }
}