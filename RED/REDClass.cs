using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using RED.Core;
using RED.Reflection;
using RED.Utilities;
using RED.IO;
using System.Diagnostics.Contracts;
using System.ComponentModel;
using System.Reflection;

namespace RED
{
    /// <summary>
    /// Represents the base class for all REDEngine classes
    /// </summary>
    public abstract class REDClass : IExportable
    {
        












    }


















    public static class PropertyReader
    {
        public static void ReadObject(object instance, REDBinaryReader r)
        {
            // Each object is prefixed with a zero byte header.
            var b = r.ReadByte();
            if(b != 0)
            {
                throw new FormatException($"Invalid object null header: {b}");
            }

            // Keep looping until the 2 byte null termintator is reached.
            while (true)
            {
                var name = r.ReadCName();
                if (CName.IsNullOrEmpty(name))
                {
                    // 2 byte null terminator instead of the next name id indicates the end of the object.
                    break;
                }
                var type = r.ReadCName();

                var start = r.BaseStream.Position;
                var size  = r.ReadUInt32();
                // Size value includes the size of the uint itself (+ 4).
                if (size < sizeof(uint))
                {
                    throw new FormatException($"Invalid object size: {size}");
                }

                // Check to see if the current class contains a property with the name and type read.
                var field = REDReflection.GetREDField(instance.GetType(), name, type);
                if (field == null)
                {
                    throw new FormatException($"Property '{name}' : '{type}', not found in class {instance.GetType().Name}, Aborting!");
                }

                var value = ReadProperty(field.FieldType, r);

                var diff  = r.BaseStream.Position - start;
                if(diff != size)
                {
                    throw new FormatException($"Property '{name}' : '{type}', read unknown size of bytes, aborting!");
                }

                field.SetValue(instance, value);
            }
        }

        public static object ReadProperty(Type type, REDBinaryReader r)
        {
            #region .NET Types
            //Enum must be checked first because enums will be mistaken for values with typecode.
            if(type.IsEnum)
            {
                return r.ReadEnumerator(type);
            }

            if(type.IsArray)
            {
                //Handles cases of properties such as [7]Float or [5]Int32
                //Do not know how these are serialized yet.
                throw new NotImplementedException();
            }

            //Handles all commom types from the .NET framework.
            var tCode = Type.GetTypeCode(type);
            switch(tCode)
            {
                case TypeCode.Byte:     return r.ReadByte();
                case TypeCode.UInt16:   return r.ReadUInt16();
                case TypeCode.UInt32:   return r.ReadUInt32();
                case TypeCode.UInt64:   return r.ReadUInt64();
                case TypeCode.SByte:    return r.ReadSByte();
                case TypeCode.Int16:    return r.ReadInt16();
                case TypeCode.Int32:    return r.ReadInt32();
                case TypeCode.Int64:    return r.ReadInt64();
                case TypeCode.Boolean:  return r.ReadBoolean();
                case TypeCode.Single:   return r.ReadSingle();
                case TypeCode.Double:   return r.ReadDouble();
                case TypeCode.String:   return r.ReadString();
            }
            #endregion

            #region Objects
            if(!type.IsAbstract)
            {
                var value = Activator.CreateInstance(type);
                if(value is IExportable obj)
                {
                    //obj.ReadExport(stream, data);
                    return obj;
                }
                else
                {
                    ReadObject(value, r);
                }
                return value;
            }
            #endregion

            throw new InvalidDataException();
        }
    }

    public static class PropertyWriter
    {
        public static void WriteObject(IExportable instance, REDBinaryWriter red)
        {
            red.Write((byte)0);

            var fields = REDReflection.GetREDFields(instance.GetType());
            foreach (var field in fields)
            {
                var value = field.GetValue(instance);

                if (value == null || value == default)
                    continue;

                var (name, type) = REDReflection.GetREDNameTypePair(field);
                red.Write((CName)name);
                red.Write((CName)type);

                var start = red.BaseStream.Position;
                red.Write(0u);
                WriteProperty(value, red);

                var end = red.BaseStream.Position;
                red.BaseStream.Seek(start, SeekOrigin.Begin);
                red.Write(Convert.ToUInt32(end - start));
                red.BaseStream.Seek(end, SeekOrigin.Begin);
            }

            red.Write((ushort)0);
        }

        public static void WriteProperty(object value, REDBinaryWriter stream)
        {
            var type = value.GetType();
            if (type.IsEnum)
            {
                var names = EnumExtensions.ConvertToNames((Enum)value);
                if (type.IsDefined(typeof(FlagsAttribute), false))
                {
                    foreach (var name in names)
                    {
                        stream.Write(name);
                    }
                    stream.Write((ushort)0);
                }
                else
                {
                    if (names.Count() == 0)
                    {
                        stream.Write((ushort)0);
                    }
                    else
                    {
                        stream.Write(names.First());
                    }
                }
                return;
            }

            var tCode = Type.GetTypeCode(type);
            switch (tCode)
            {
                case TypeCode.Byte:     stream.Write((byte)value);      return;
                case TypeCode.UInt16:   stream.Write((ushort)value);    return;
                case TypeCode.UInt32:   stream.Write((uint)value);      return;
                case TypeCode.UInt64:   stream.Write((ulong)value);     return;
                case TypeCode.SByte:    stream.Write((sbyte)value);     return;
                case TypeCode.Int16:    stream.Write((short)value);     return;
                case TypeCode.Int32:    stream.Write((int)value);       return;
                case TypeCode.Int64:    stream.Write((long)value);      return;
                case TypeCode.Boolean:  stream.Write((bool)value);      return;
                case TypeCode.Single:   stream.Write((float)value);     return;
                case TypeCode.Double:   stream.Write((double)value);    return;
                case TypeCode.String:   stream.Write((string)value);    return;
            }


            if (value is IExportable obj)
            {

            }
        }
    }
}

