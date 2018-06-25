using System;
using System.IO;
using CR2W.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CR2W.Attributes;
using System.Reflection;
using System.Text;
using System.Diagnostics;

namespace CR2W.Types.W3
{
    /// <summary>
    /// Represnts a Witcher 3 object that can be read by the RedEngine3.
    /// This is the base class of all RedEngine3 serializable types.
    /// </summary>
    public abstract class CObject : ISerializable, IReferencable, IScriptable
    {
        public Dictionary<uint, CObject> Children { get; set; }
        public uint Template { get; set; }
        public uint Flags { get; set; }

        public CObject()
        {
            Children = new Dictionary<uint, CObject>();
            Console.WriteLine($"CObject created: {this.GetType().Name}");
        }

        /// <summary>
        /// Get the CObject parent for this instance 
        /// </summary>
        /// <returns>Parent Object</returns>
        public CObject GetParent()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clone the current instance to a new parent
        /// </summary>
        /// <param name="newParent">Parent to clone to</param>
        /// <returns>Cloned Instance</returns>
        public CObject Clone( CObject newParent )
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if this instance is refered to in another CObject
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Boolean if the CObject is in it</returns>
        public bool IsIn( CObject check )
        {
            throw new NotImplementedException();
        }

        public virtual void ParseBytes(CR2WBinaryReader br, uint size)
        {
            ParseClass(br, this);
            #region Comments
            // - TODO:
            //      Figure out an elegant solution to map the data within a chunk to the class structure.
            //      Problems so far are:
            //          1) Looping through an unknown number of nested types and mapping the values whilst
            //             keeing track of where the stream position is.
            //             On top of that use attributes to find the right values and using the right 
            //             object parser for each type of variable.
            //             Solutions are: 
            //                  - Use the attrubutes themselves to cascade down parsring and setting the values
            //                  - Have a standalone set of functions within CR2W.IO.CR2WParser that work on recursion
            //                    to keep nesting throughout the class structure.
            //                  - Write a parser into each base variable type (ints, floats, CName etc...) as an extenstion method 
            //                    and call those methods, if not found then nest into the class and repeat.
            //                    
            //          2) Figure out how to get array to map properly.
            //             Arrays are annoying to work with. In particular arrays of arrays. Atributes are not really a decent solution.
            //             Alternative is to write the parser into the CArray class type which would work but would cause a headache later 
            //             when it has to fit with the rest of the system that may use attributes to parse the value.
            //             
            //          3) Get a system that can read past the class structure bytes
            //             For some files such as CSwfResource, CBitmapTexture, or CRagdoll where there is more info in the chunk that extends
            //             beyond the class structre. Data there needs specific parsers for each specific case.
            //             These can be written into the CResource class on an individual basis, but as before if the system uses
            //             attributes to map the values then there will be problems trying to integrate this.
            #endregion
        }

        protected void ParseClass(CR2WBinaryReader br, object instance)
        {
            br.ReadByte();
            while (true)
            {
                var nameId = br.ReadUInt16();
                if(nameId == 0)
                {
                    break;
                }
                var typeId = br.ReadInt16();
                var size = br.ReadUInt32() - 4;
                var prop = instance.GetType().GetREDProperty(br.names[nameId], br.names[typeId]);
                if(prop == null)
                {
                    Console.WriteLine("ERROR - Property {0} : {1} not found, skipping!", br.names[nameId], br.names[typeId]);
                    br.BaseStream.Seek(size, SeekOrigin.Current);
                    continue;
                }
                var value = ParseProperty(br, prop.PropertyType);
                prop.SetValue(instance, value);
            }
        }

        protected object ParseProperty(CR2WBinaryReader br, Type proptype)
        {
            //Basic / Value Types
            switch (proptype.Name)
            {
                case "Byte":              return br.ReadByte();
                case "UInt16":            return br.ReadUInt16();
                case "UInt32":            return br.ReadUInt32();
                case "UInt64":            return br.ReadUInt64();
                case "SByte":             return br.ReadSByte();
                case "Int16":             return br.ReadInt16();
                case "Int32":             return br.ReadInt32();
                case "Int64":             return br.ReadInt64();
                case "Boolean":           return br.ReadBoolean();
                case "Single":            return br.ReadSingle();
                case "Double":            return br.ReadDouble();
                case "CName":             return br.ReadCName();
                case "CGUID":             return br.ReadCGUID();
                case "IdTag":             return br.ReadIdTag();
                case "TagList":           return br.ReadTagList();
                case "EngineTransform":   return br.ReadEngineTransform();
                case "EngineQsTransform": return br.ReadEngineQsTransform();
                case "CDateTime":         return br.ReadCDateTime();
                case "String":            return br.ReadStringDefaultSingle();
            }

            //Parse Enumarators
            if (proptype.IsEnum)
            {
                return br.ReadEnumerator(proptype);
            }

            //Parse Generic Types (Array, Soft, Ptr, Handle)
            if(proptype.IsGenericType)
            {
                var instance = Activator.CreateInstance(proptype);
                var genprop = proptype.GetTypeInfo().GenericTypeArguments[0];
                if(proptype.GetGenericTypeDefinition() == typeof(Array<>))
                {
                    var length = br.ReadUInt32();
                    for (int i = 0; i < length; i++)
                    {
                        var value = ParseProperty(br, genprop);
                        proptype.GetMethod("Add").Invoke(instance, new[] { value });
                    }
                }
                else if(proptype.GetGenericTypeDefinition() == typeof(Soft<>))
                {
                    var id = br.ReadUInt16() - 1;
                    if(br.resources[id].type != genprop.Name)
                    {
                        throw new InvalidOperationException($"Soft type mismatch. Expected Type: {genprop.Name}. Type Read: {br.resources[id].type}.");
                    }
                    proptype.GetProperty("DepotPath").SetValue(instance, br.resources[id].path);
                    proptype.GetProperty("Flags").SetValue(instance, br.resources[id].flags);
                }
                else if (proptype.GetGenericTypeDefinition() == typeof(Ptr<>))
                {
                    var id = br.ReadUInt16();
                    proptype.GetProperty("Index").SetValue(instance, id);
                }
                else if (proptype.GetGenericTypeDefinition() == typeof(Handle<>))
                {
                    var id = br.ReadInt32();
                    if (id >= 0)
                    {
                        proptype.GetProperty("Type").SetValue(instance, EHandleType.ReferenceHandle);
                        proptype.GetProperty("Index").SetValue(instance, id);
                    }
                    else
                    {
                        id *= -1;
                        proptype.GetProperty("Type").SetValue(instance, EHandleType.ResourceHandle);
                        proptype.GetProperty("DepotPath").SetValue(instance, br.resources[id-1].path);
                        proptype.GetProperty("Flags").SetValue(instance, br.resources[id-1].flags);
                    }
                }
                return instance;
            }

            //Parse classes
            if (proptype.IsClass)
            {
                var instance = Activator.CreateInstance(proptype);
                ParseClass(br, instance);
                return instance;
            }

            //Any Unknown Type
            //Should be impossible to reach if all types get covered above.
            return null;
        }
    }
}
