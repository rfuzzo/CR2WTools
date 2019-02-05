using RED.IO;
using RED.Reflection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RED.CR2W
{
    public class CR2WPropertyReader
    {
        public void ParseObject(object instance, REDBinaryReader red)
        {
            // Each object is prefixed with a zero byte header.
            var b = red.ReadByte();
            if (b != 0)
            {
                throw new FormatException($"Invalid object null header: {b}");
            }

            // Keep looping until the 2 byte null termintator is reached.
            while (true)
            {
                var name = red.ReadCName();
                if (CName.IsNullOrEmpty(name))
                {
                    // 2 byte null terminator instead of the next name id indicates the end of the object.
                    break;
                }
                var type = red.ReadCName();

                var start = red.BaseStream.Position;
                var size = red.ReadUInt32();
                // Size value includes the size of the uint size value itself (+ 4).
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

                var value = ReadObject(field.FieldType, red);

                var diff = start.CompareTo(red.BaseStream.Position);
                if (diff != 0)
                {
                    throw new FormatException($"Property '{name}' : '{type}', read unknown size of bytes, aborting!");
                }

                field.SetValue(instance, value);
            }
        }

        public object ReadObject(Type type, REDBinaryReader red)
        {
            #region .NET Types
            //Enum must be checked first because enums will be mistaken for values with typecode.
            if (type.IsEnum)
            {
                return red.ReadEnumerator(type);
            }

            // Handles types such as [7]Float or [4]Int32
            if (type.IsArray)
            {
                var arraySize = red.ReadUInt32();
                var arrayType = type.GetElementType();
                var array = Array.CreateInstance(arrayType, arraySize);
                for (int i = 0; i < arraySize; i++)
                {
                    var value = ReadObject(arrayType, red);
                    array.SetValue(value, i);
                }
                return array;
            }

            // Handles all commom types from the .NET framework.
            var tCode = Type.GetTypeCode(type);
            switch (tCode)
            {
                case TypeCode.Byte:     return red.ReadByte();
                case TypeCode.UInt16:   return red.ReadUInt16();
                case TypeCode.UInt32:   return red.ReadUInt32();
                case TypeCode.UInt64:   return red.ReadUInt64();
                case TypeCode.SByte:    return red.ReadSByte();
                case TypeCode.Int16:    return red.ReadInt16();
                case TypeCode.Int32:    return red.ReadInt32();
                case TypeCode.Int64:    return red.ReadInt64();
                case TypeCode.Boolean:  return red.ReadBoolean();
                case TypeCode.Single:   return red.ReadSingle();
                case TypeCode.Double:   return red.ReadDouble();
                case TypeCode.String:   return red.ReadString();
            }
            #endregion

            #region Objects
            if (!type.IsAbstract)
            {
                var value = Activator.CreateInstance(type);
                if (value is IExportable obj)
                {
                    
                }
                else
                {
                    ParseObject(value, red);
                }
                return value;
            }
            #endregion

            throw new InvalidDataException();
        }
    }
}
