using System;
using System.IO;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public abstract class CObject : ISerializable, IReferencable, IScriptable
    {
        public uint Flags { get; set; }

        public virtual void ParseBytes(BinaryReader br, CR2WParser parser)
        {
            Console.WriteLine("Parse Bytes Begin:");
            Console.WriteLine($"\t- Type:  {GetType().Name}");
            Console.WriteLine($"\t- Size:  {br.BaseStream.Length} bytes");
            Console.WriteLine($"\t- Flags: {Flags}");

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
             *          3) Get a system that can get read past the class structure bytes
             *             For some files such as CSwfResource, CBitmapTexture, or CRagdoll where there is more info in the chunk that extends
             *             beyond the class structre. Data there needs specific parsers for each specific case.
             *             These can be written into the CResource class on an individual basis, but as before if the system uses
             *             attributes to map the values then there will be problems trying to integrate this.
             *             
             */
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
    }
}
