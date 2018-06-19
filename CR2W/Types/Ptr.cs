using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.Exceptions;
using CR2W.IO;
using CR2W.Types.W3;

namespace CR2W.Types
{
    public struct Ptr<T>
    {
        /*
         * 
         *  A ptr is a pointer to a CObject instance
         *  That CObject will be held in CObject.Children.
         *  (The instance that this Ptr instance will be held in)
         * 
         *  This class should only contain a reference to the CObject in that list,
         *  and not the object itself.
         * 
         * 
         */

        public int Target { get; set; } //if children are referenceable by GUID, if not, int?

        
        public void ParseBytes(CR2WBinaryReader parser, uint size)
        {
            throw new NotImplementedException();
        }
    }



}