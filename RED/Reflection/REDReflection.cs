using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using RED.FNV1A;

namespace RED.Reflection
{
    /// <summary>
    /// Provides static methods for reading .NET runtime information 
    /// and converting to redengine compatible representations.
    /// </summary>
    public static class REDReflection
    {
        public static ulong ComputeFieldInfoHash(FieldInfo info)
        {
            var fieldName     = GetREDNameString(info);
            var declaringName = info.DeclaringType.Name;

            var fnv = new FNV1A64HashAlgorithm();

            fnv.AppendString(declaringName, true);
            fnv.AppendString(fieldName, true);

            return fnv.HashUInt64;
        }

        public static (string name, string type) GetREDNameTypePair(FieldInfo field)
        {
            var attribute = field.GetCustomAttribute<REDAttribute>();
            if(attribute is null)
            {
                return (null, null);
            }
            var flags = attribute.Flags.AsEnumerable().GetEnumerator();
            if (String.IsNullOrWhiteSpace(attribute.Name))
            {
                return (field.Name, GetREDTypeString(field.FieldType, flags));
            }
            return (attribute.Name, GetREDTypeString(field.FieldType, flags));
        }

        public static string GetREDNameString(FieldInfo field)
        {
            var attribute = field.GetCustomAttribute<REDAttribute>();
            if (attribute is null || String.IsNullOrWhiteSpace(attribute.Name))
            {
                return field.Name;
            }
            return attribute.Name;
        }

        public static string GetREDTypeString(FieldInfo field)
        {
            var attribute = field.GetCustomAttribute<REDAttribute>();
            if(attribute is null)
            {
                return null;
            }
            var flags = attribute.Flags.AsEnumerable().GetEnumerator();
            return GetREDTypeString(field.FieldType, flags);
        }
        public static string GetREDTypeString(Type type, params int[] flags)
        {
            return GetREDTypeString(type, flags.AsEnumerable().GetEnumerator());
        }
        public static string GetREDTypeString(Type type, IEnumerator<int> flags)
        {
            // Handles .Net types that have different names.
            // Types such as Double, Int32, or Int16 are the same.
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:    return "Uint8";
                case TypeCode.UInt16:  return "Uint16";
                case TypeCode.UInt32:  return "Uint32";
                case TypeCode.UInt64:  return "Uint64";
                case TypeCode.SByte:   return "Int8";
                case TypeCode.Boolean: return "Bool";
                case TypeCode.Single:  return "Float";
            }

            // Handles arrays, such as [5]Float, in C++ these would be defined fixed arrays.
            // Here the size will be defined in the attribute, as C# can't define fixed arrays in classes like C++
            if (type.IsArray)
            {
                var arrProp = type.GetElementType();
                var size = flags.MoveNext() ? flags.Current : 0;
                return $"[{size}]{GetREDTypeString(arrProp, flags)}";
            }

            // Handles the 5 generic types: array:2,0,Int8, ptr:CObject, 
            // static:4,Int32, handle:ISerializable and soft:CResource.
            if (type.IsGenericType)
            {
                var genprop = type.GetTypeInfo().GenericTypeArguments[0];
                var gentype = type.GetGenericTypeDefinition();
                if (gentype == typeof(TDynArray<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    var v2 = flags.MoveNext() ? flags.Current : 0;
                    return $"array:{v1},{v2},{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(Pointer<>))
                {
                    return $"ptr:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(Soft<>))
                {
                    return $"soft:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(Handle<>))
                {
                    return $"handle:{GetREDTypeString(genprop, flags)}";
                }
                if (gentype == typeof(Static<>))
                {
                    var v1 = flags.MoveNext() ? flags.Current : 0;
                    return $"static:{v1},{GetREDTypeString(genprop, flags)}";
                }
            }

            // No match returns the default .NET name.
            return type.Name;
        }

        public static IEnumerable<FieldInfo> GetREDFields(Type type)
        {
            var allFields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            return allFields.Where(prop => prop.IsDefined(typeof(REDAttribute)));
        }
        public static IEnumerable<FieldInfo> GetREDFields(Type type, BindingFlags flags)
        {
            var allFields = type.GetFields(flags);
            return allFields.Where(prop => prop.IsDefined(typeof(REDAttribute)));
        }

        public static FieldInfo GetREDField(Type classType, string name, string type)
        {
            var fields = GetREDFields(classType).Where(field =>
            {
                var attribute = field.GetCustomAttribute<REDAttribute>();
                var flags = attribute.Flags.AsEnumerable().GetEnumerator();
                var n = attribute.Name;
                if (String.IsNullOrWhiteSpace(n))
                {
                    n = field.Name;
                }
                return n == name && GetREDTypeString(field.FieldType, flags) == type;
            });
            return fields.FirstOrDefault();
        }

        public static IEnumerable<string> GetREDFieldList(Type type)
        {
            var fields = GetREDFields(type);
            var nameTypes = fields.Select(field => GetREDNameTypePair(field));
            var maxWidth = nameTypes.Max(nt => nt.name.Length);
            return nameTypes.Select(nt => String.Format("{0} {1}", nt.name.PadRight(maxWidth), nt.type));
        }
    }
}
