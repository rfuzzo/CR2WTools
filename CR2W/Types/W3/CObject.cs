using System;
using System.IO;
using CR2W.IO;
using System.Collections.Generic;
using System.Linq;
using CR2W.Attributes;
using System.Reflection;
using System.Text;

namespace CR2W.Types.W3
{
    public abstract class CObject : ISerializable, IReferencable, IScriptable
    {
        public uint Template { get; set; }
        public Dictionary<Guid, CObject> Children  { get; set; }
        public uint Flags { get; set; }

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
            //Console.WriteLine($"\t- Children: {Children.Count}");

            /*
             *  - TODO:
             *      Figure out an elegant solution to map the data within a chunk to the class structure.
             *      Problems so far are:
             *          1) Looping through an unknown number of nested types and mapping the values whilst
             *             keeing track of where the stream position is.
             *             On top of that use attributes to find the right values and using the right 
             *             object parser for each type of variable.
             *             Solutions are: 
             *                  - Use the attrubutes themselves to cascade down parsring and setting the values
             *                  - Have a standalone set of functions within CR2W.IO.CR2WParser that work on recursion
             *                    to keep nesting throughout the class structure.
             *                  - Write a parser into each base variable type (ints, floats, CName etc...) as an extenstion method 
             *                    and call those methods, if not found then nest into the class and repeat.
             *                    
             *          2) Figure out how to get array to map properly.
             *             Arrays are annoying to work with. In particular arrays of arrays. Atributes are not really a decent solution.
             *             Alternative is to write the parser into the CArray class type which would work but would cause a headache later 
             *             when it has to fit with the rest of the system that may use attributes to parse the value.
             *             
             *          3) Get a system that can read past the class structure bytes
             *             For some files such as CSwfResource, CBitmapTexture, or CRagdoll where there is more info in the chunk that extends
             *             beyond the class structre. Data there needs specific parsers for each specific case.
             *             These can be written into the CResource class on an individual basis, but as before if the system uses
             *             attributes to map the values then there will be problems trying to integrate this.
             *             
             */

            var end = br.BaseStream.Position + size;
            Console.WriteLine("Data");
            Console.WriteLine("{");
            ReadVariable(br, "\t");
            Console.WriteLine("}");
            if (end - br.BaseStream.Position != 0)
            {
                Console.WriteLine("Unknown Bytes: {0}", end - br.BaseStream.Position);
                var unknown = br.ReadBytes(Convert.ToInt32(end - br.BaseStream.Position));
                Console.WriteLine("Unknown Data: |{0}|", Encoding.ASCII.GetString(unknown));
            }
            else
            {
                Console.WriteLine("Unknown Bytes: 0");
            }
            Console.WriteLine();
        }

        [Obsolete("This will need to be replaced by a proper class mapping system.")]
        private void ReadVariable(CR2WBinaryReader br, string offset)
        {
            br.ReadByte();
            while (true)
            {
                var nameId = br.ReadInt16();
                if (nameId == 0)
                {
                    break;
                }
                var typeId = br.ReadInt16();
                var size = br.ReadInt32() - 4;
                Console.Write("{0}{1} {2}", offset, br.names[nameId], br.names[typeId]);
                ParseVariale(br, br.names[typeId], size, $"\t{offset}");
            }
        }

        [Obsolete("This will need to be replaced by a proper class mapping system.")]
        private void ParseVariale(CR2WBinaryReader br, string type, int size, string offset)
        {
            var arr = type.Split(new char[] { ':' }, 2);
            switch (arr[0])
            {
                case "Uint8":
                    Console.WriteLine(" {0}", br.ReadByte());
                    return;
                case "Uint16":
                    Console.WriteLine(" {0}", br.ReadUInt16());
                    return;
                case "Uint32":
                    Console.WriteLine(" {0}", br.ReadUInt32());
                    return;
                case "Uint64":
                    Console.WriteLine(" {0}", br.ReadUInt64());
                    return;
                case "Int8":
                    Console.WriteLine(" {0}", br.ReadSByte());
                    return;
                case "Int16":
                    Console.WriteLine(" {0}", br.ReadInt16());
                    return;
                case "Int32":
                    Console.WriteLine(" {0}", br.ReadInt32());
                    return;
                case "Int64":
                    Console.WriteLine(" {0}", br.ReadInt64());
                    return;
                case "Float":
                    Console.WriteLine(" {0}", br.ReadSingle());
                    return;
                case "Double":
                    Console.WriteLine(" {0}", br.ReadDouble());
                    return;
                case "String":
                    Console.WriteLine(" {0}", br.ReadCR2WStringSingle());
                    return;
                case "StringAnsi":
                    Console.WriteLine(" {0}", br.ReadStringAnsi());
                    return;
                case "Bool":
                    Console.WriteLine(" {0}", br.ReadBoolean());
                    return;
                case "CName":
                    Console.WriteLine(" {0}", br.ReadCName());
                    return;
                case "CGUID":
                    Console.WriteLine(" {0}", br.ReadCGUID());
                    return;
                case "LocalizedString":
                    Console.WriteLine(" {0}", br.ReadUInt32());
                    return;
                case "ptr":
                    Console.WriteLine(" Chunk {0}", br.ReadUInt32());
                    return;
                case "soft":
                    var Id = br.ReadUInt16();
                    Console.WriteLine(" {0} {1} ({2})", br.resources[Id - 1].type, br.resources[Id - 1].path, br.resources[Id - 1].flags);
                    return;
                case "array":
                    var len = br.ReadUInt32();
                    arr = arr[1].Split(new char[] { ',' }, 3);
                    Console.WriteLine(" {0}", len);
                    Console.WriteLine("{0}{{", offset.Substring(1));
                    for (uint i = 0; i < len; i++)
                    {
                        Console.Write("{0}Id {1}:", offset, i);
                        ParseVariale(br, arr[2], size, $"\t{offset}");
                    }
                    Console.WriteLine("{0}}}", offset.Substring(1));
                    return;
                case "handle":
                    Console.WriteLine(" Chunk {0}", br.ReadInt32());
                    return;
                case "static":
                case "IdTag":
                case "DeferredDataBuffer":
                case "SharedDataBuffer":
                case "EntityHandle":
                case "EngineTransform":
                case "TagList":
                case "CClipMapCookedData":
                case "DataBuffer":
                    Console.WriteLine(" {0} bytes", size);
                    br.ReadBytes(size);
                    return;
            }
            Type myType = Type.GetType($"CR2W.Types.W3.{type}");
            if (myType != null)
            {
                if (myType.IsEnum)
                {
                    Console.WriteLine(" {0}", br.names[br.ReadUInt16()]);
                    return;
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}{{", offset.Substring(1));
            ReadVariable(br, offset);
            Console.WriteLine("{0}}}", offset.Substring(1));
        }

        /// <summary>
        /// Get the first property from an instance where the name given matches that of the name defined in a W3TypeAttribute. 
        /// </summary>
        /// <param name="name">Name to check for</param>
        /// <param name="value">The object instance to check in</param>
        /// <returns>A property info object of the first property with the name</returns>
        public static PropertyInfo GetPropertyByW3Name(string name, object value)
        {
            var props = value.GetType().GetProperties().Where(prop =>
            {
                if (prop.IsDefined(typeof(W3TypeAttribute), false))
                {
                    var attribute = (W3TypeAttribute)prop.GetCustomAttribute(typeof(W3TypeAttribute));
                    return attribute.Name == name;
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

        public override string ToString()
        {
            return String.Format("[{0}] Template: {1} Flags: {2} Children: {3}", GetType().Name, Template, Flags, Children.Count);
        }
    }
}
