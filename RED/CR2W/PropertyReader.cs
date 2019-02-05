using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RED.Engine.CR2W
{
    public static class PropertyReader
    {
        /*
        public static void ReadClass(object instance, BinaryReader br, CFileData file)
        {
            br.ReadByte();
            while (true)
            {
                var nameId = br.ReadUInt16();
                if (nameId == 0)
                    break;

                var typeId = br.ReadUInt16();
                var size = br.ReadUInt32() - 4;

                var name = file.GetName(nameId);
                var type = file.GetName(typeId);

                var field = instance.GetType().GetREDField(name, type);

                if (field == null)
                {
                    br.BaseStream.Seek(size, SeekOrigin.Current);
                    continue;
                }

                var value = ReadValue(field.FieldType, br, file);
                if(value == null)
                {
                    br.BaseStream.Seek(size, SeekOrigin.Current);
                    continue;
                }

                field.SetValue(instance, value);
            }
        }

        public static object ReadValue(Type type, BinaryReader br, CFileData file)
        {
            #region Existing .NET Types
            switch (type.Name)
            {
                case "Byte":    return br.ReadByte();
                case "UInt16":  return br.ReadUInt16();
                case "UInt32":  return br.ReadUInt32();
                case "UInt64":  return br.ReadUInt64();
                case "SByte":   return br.ReadSByte();
                case "Int16":   return br.ReadInt16();
                case "Int32":   return br.ReadInt32();
                case "Int64":   return br.ReadInt64();
                case "Boolean": return br.ReadBoolean();
                case "Single":  return br.ReadSingle();
                case "String":  return br.ReadREDString();
            }
            #endregion

            #region Enumerators
            if (type.IsEnum)
            {
                if (type.IsDefined(typeof(FlagsAttribute), false))
                {
                    var values = new List<string>();
                    while (true)
                    {
                        var flag = br.ReadUInt16();
                        if (flag == 0)
                        {
                            break;
                        }
                        values.Add(file.GetName(flag));
                    }
                    if (values.Count != 0)
                    {
                        return Enum.Parse(type, String.Join(",", values));
                    }
                }
                return Enum.Parse(type, file.GetName(br.ReadUInt16()));
            }
            #endregion

            #region IREDClassTypes
            // Reads classes or structs the inherit from IREDClass
            // Implenetation will depend on the specific class. 
            if (typeof(IREDClass).IsAssignableFrom(type))
            {
                var value = (IREDClass)Activator.CreateInstance(type);
                return value;
            }
            #endregion

            //Should be impossible to reach if all the types get covered above.
            return null;
        }
        */


        #region Extension Methods
        public static int ReadVLQInt32(this BinaryReader br)
        {
            var b1 = br.ReadByte();
            var sign = (b1 & 128) == 128;
            var next = (b1 & 64) == 64;
            var size = b1 % 128 % 64;
            var offset = 6;
            while (next)
            {
                var b = br.ReadByte();
                size = (b % 128) << offset | size;
                next = (b & 128) == 128;
                offset += 7;
            }
            return sign ? size * -1 : size;
        }

        public static string ReadREDString(this BinaryReader br)
        {
            var length = br.ReadVLQInt32();
            if (length < 0)
            {
                return Encoding.ASCII.GetString(br.ReadBytes(length * -1));
            }
            return Encoding.Unicode.GetString(br.ReadBytes(length * 2));
        }
        #endregion
    }
}
