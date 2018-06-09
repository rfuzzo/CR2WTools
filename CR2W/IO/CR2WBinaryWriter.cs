using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Types.W3;

namespace CR2W.IO
{
    public sealed class CR2WBinaryWriter
    {
        private uint AddToStringTable( string value )
        {
            /*
             * TODO - Add a new string to the dictionary and return the offset that string starts at.
             */
            throw new NotImplementedException();
        }

        public ushort AddNewReference( string value )
        {
            /*
             * TODO - Add a new string to the references list, and return the index that is in the list
             * If it already exists, do not add, but just return the index of the exsisting one.
             * Will also need to add the CRC32 checksum once how its calculated is figured out.
             */
            throw new NotImplementedException();
        }

        public ushort AddNewHandle( string type, string path, uint flags )
        {
            /*
             * TODO - Add a new handle object and serialize that.
             * Take the strings for type and path and add them to the references with
             * AddNewReference();
             * Might look like:
             * 
             *      var pathOffset = AddToDictionary(path);
             *      var typeId = AddNewReference(type);
             * 
             *      bw.Write(pathoffset);
             *      bw.Write(typeId);
             *      br.Write(flags);
             * 
             */

            throw new NotImplementedException();
        }

        private void CreateFile( CResource value )
        {

        }

    }
}
