using System;
using System.IO;
using CR2W.IO;
using System.Collections.Generic;
using System.Linq;
using CR2W.Attributes;
using CR2W.Exceptions;
using System.Reflection;
using System.Text;
using System.Diagnostics;

namespace CR2W.Types.W3
{
    public abstract class CObject : ISerializable, IReferencable, IScriptable
    {
        public uint Template { get; set; }
        public uint Flags { get; set; }

        //Here will reside all the of the childern that this CObject instance is dependent on 
        //This will be where all of the CObjects that any ptr or object handle refer to.
        //atm its just a dictionary with a guid as the key.
        public Dictionary<Guid, CObject> Children  { get; set; }

        public CObject()
        {
            Children = new Dictionary<Guid, CObject>();
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
            Console.WriteLine("Parse Bytes Begin:");
            Console.WriteLine($"\t- Type:     {GetType().Name}");
            Console.WriteLine($"\t- Size:     {size} bytes");
            Console.WriteLine($"\t- Flags:    {Flags}");
            Console.WriteLine($"\t- Children: {Children.Count}");

            Console.WriteLine();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Mapping Data...");
            sw.Start();
            ParseClass(br, this);
            sw.Stop();
            Console.WriteLine("Done - Time Taken: {0} seconds", (float)sw.ElapsedMilliseconds/(float)1000);
            Console.WriteLine();

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

        public override string ToString()
        {
            return String.Format("[{0}] Template: {1} Flags: {2} Children: {3}", GetType().Name, Template, Flags, Children.Count);
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
                var prop = GetPropertybyW3Name(br.names[nameId], instance.GetType());
                var value = ParseVariable(br, prop.PropertyType);
                prop.SetValue(instance, value);
            }
        }

        protected object ParseVariable(CR2WBinaryReader br, Type proptype )
        {
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
            }

            if (proptype.IsEnum)
            {
                return br.ReadEnumarator(proptype);
            }

            if (proptype.IsClass)
            {
                var instance = Activator.CreateInstance(proptype);
                ParseClass(br, instance);
                return instance;
            }

            return null;
        }

        public static PropertyInfo GetPropertybyW3Name( string name, Type parent )
        {
            var props = parent.GetProperties().Where(prop =>
            {
                if(prop.IsDefined(typeof(W3TypeAttribute)))
                {
                    var attribute = (W3TypeAttribute)prop.GetCustomAttribute(typeof(W3TypeAttribute));
                    return attribute.Name == name;
                }
                else
                {
                    return false;
                }
            });
            if(props.Any())
            {
                return props.First();
            }
            return null;
        }
    }
}
