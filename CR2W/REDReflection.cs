using CR2W.Attributes;
using CR2W.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CR2W
{
    public static class REDReflection
    {
        public static PropertyInfo GetREDProperty(this Type parent, string name, string type)
        {
            var props = parent.GetProperties().Where(prop =>
            {
                if (prop.IsDefined(typeof(REDPropAttribute)))
                {
                    var attribute = (REDPropAttribute)prop.GetCustomAttribute(typeof(REDPropAttribute));
                    var flags = new Stack<byte>(attribute.Flags.Reverse());
                    if(attribute.Name != name)
                    {
                        return false;
                    }
                    return prop.PropertyType.GetREDString(flags) == type;
                }
                else
                {
                    return false;
                }
            });
            if (props.Any())
            {
                return props.First();
            }
            return null;
        }

        public static string GetREDString( this Type type, Stack<byte> flags)
        {
            switch (type.Name)
            {
                case "Byte": return "Uint8";
                case "UInt16": return "Uint16";
                case "UInt32": return "Uint32";
                case "UInt64": return "Uint64";
                case "SByte": return "Int8";
                case "Boolean": return "Bool";
                case "Single": return "Float";
            }
            if (type.IsGenericType)
            {
                var genprop = type.GetTypeInfo().GenericTypeArguments[0];
                if (type.GetGenericTypeDefinition() == typeof(Array<>))
                {
                    return $"array:{flags.SafePop()},{flags.SafePop()},{GetREDString(genprop, flags)}";
                }
                if (type.GetGenericTypeDefinition() == typeof(Ptr<>))
                {
                    return $"ptr:{GetREDString(genprop, flags)}";
                }
                if (type.GetGenericTypeDefinition() == typeof(Soft<>))
                {
                    return $"soft:{GetREDString(genprop, flags)}";
                }
                if (type.GetGenericTypeDefinition() == typeof(Handle<>))
                {
                    return $"handle:{GetREDString(genprop, flags)}";
                }
            }
            return type.Name;
        }

        public static T SafePop<T>( this Stack<T> value ) where T : new()
        {
            if(value.Count == 0)
            {
                return new T();
            }
            return value.Pop();
        }
    }
}
