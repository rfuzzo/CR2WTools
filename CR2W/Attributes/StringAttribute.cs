using System;
using System.IO;
using CR2W.IO;
using CR2W.Types;
using CR2W.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace CR2W.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class StringAttribute : CR2WPropertyAttribute
    {
        public StringAttribute(string name) : base(name, "String") { }

        public override object DeSerialize(BinaryReader br, CR2WParser p)
        {
            List<string> list = new List<string>();
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                int len = br.ReadSByte();
                if (len < 0)
                {
                    len += 128;
                    if (len >= 64)
                    {
                        len -= 64;
                        len = br.ReadByte() * 64 + len;
                    }
                    list.Add(Encoding.UTF8.GetString(br.ReadBytes(len)));
                }
                else
                {
                    if (len >= 64)
                    {
                        len -= 64;
                        len = br.ReadByte() * 64 + len;
                    }
                    len *= 2;
                    list.Add(Encoding.Unicode.GetString(br.ReadBytes(len)));
                }
            }
            return list;
        }

        public override void Serialize(object value, BinaryWriter bw, CR2WExporter e)
        {
            if(value is List<string> l)
            {
                foreach (var s in l)
                {
                    bw.Write(Encoding.Default.GetBytes(s));
                }
            }
            throw new UnknownObjectTypeException("[String] Value was not a string group.");
        }
    }
}
