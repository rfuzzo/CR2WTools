using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RED.Engine.CR2W
{
    public static class PropertyWriter
    {
        /*
        public static void WriteClass(IREDClass instance, BinaryWriter bw, CFileData data)
        {
            var fields = instance.GetType().GetREDFields();

            bw.Write((Byte)0);
            foreach (var field in fields)
            {
                var value = field.GetValue(instance);

                if (value == null)
                    continue;

                var (name, type) = field.GetREDTypeNamePair();

                bw.Write(data.AddName(name));
                bw.Write(data.AddName(type));

                var start = bw.BaseStream.Position;
                
                bw.Write(0u);
                WriteValue(value, bw, data);

                var end = bw.BaseStream.Position;

                bw.BaseStream.Seek(start, SeekOrigin.Begin);
                bw.Write(Convert.ToUInt32(end - start));
                bw.BaseStream.Seek(end, SeekOrigin.Begin);
            }
            bw.Write((ushort)0);
        }

        public static void WriteValue(object value, BinaryWriter bw, CFileData data)
        {
            var type = value.GetType();

            switch(type.Name)
            {
                case "Byte":    bw.Write((byte)value);              return;
                case "UInt16":  bw.Write((ushort)value);            return;
                case "UInt32":  bw.Write((uint)value);              return;
                case "UInt64":  bw.Write((ulong)value);             return;
                case "SByte":   bw.Write((sbyte)value);             return;
                case "Int16":   bw.Write((short)value);             return;
                case "Int32":   bw.Write((int)value);               return;
                case "Int64":   bw.Write((long)value);              return;
                case "Boolean": bw.Write((bool)value);              return;
                case "Single":  bw.Write((float)value);             return;
                case "String":  bw.WriteREDString((string)value);   return;
            }

            if(type.IsEnum)
            {
                if (type.IsDefined(typeof(FlagsAttribute), false))
                {
                    var flags = value.ToString().Split(',');
                    foreach (var flag in flags)
                    {
                        bw.Write(data.AddName(flag));
                    }
                    bw.Write((ushort)0);
                }
                else
                {
                    var e = value.ToString();
                    bw.Write(data.AddName(e));
                }
            }

            if(value is IREDClass t)
            {
                //t.WriteObject(data, bw);
            }
        }
        */

        public static void WriteVLQInt32(this BinaryWriter bw, int value)
        {
            bool negative = value < 0;
            value = Math.Abs(value);
            byte b = (byte)(value & 0x3F);
            value >>= 6;
            if (negative)
            {
                b |= 0x80;
            }
            bool cont = value != 0;
            if (cont)
            {
                b |= 0x40;
            }
            bw.Write(b);
            while (cont)
            {
                b = (byte)(value & 0x7F);
                value >>= 7;
                cont = value != 0;
                if (cont)
                {
                    b |= 0x80;
                }
                bw.Write(b);
            }
        }
        public static void WriteREDString(this BinaryWriter bw, string value)
        {
            var isUniCode = Encoding.ASCII.GetByteCount(value) != value.Length;
            bw.WriteREDString(value, isUniCode);
        }
        public static void WriteREDString(this BinaryWriter bw, string value, bool isUniCode)
        {
            byte[] bytes = null;
            var length = 0;
            if (isUniCode)
            {
                bytes = Encoding.Unicode.GetBytes(value);
                length = bytes.Length;
            }
            else
            {
                bytes = Encoding.ASCII.GetBytes(value);
                length = bytes.Length * -1;
            }
            bw.WriteVLQInt32(length);
            bw.Write(bytes);
        }
    }
}
