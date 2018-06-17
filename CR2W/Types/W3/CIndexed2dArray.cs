using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;
using System.IO;

namespace CR2W.Types.W3
{
    public class CIndexed2dArray : C2dArray
    {
        public int GetRowIndexByKey( CName name )
        {
            throw new NotImplementedException();
        }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /* - Info Parsing Extra Bytes
             *   Specifically to sound_info.redicsv
             *   
             *   1st byte gives the lenght of the Array of Headers
             *   Read off that many strings using br.ReadStringDefaultSingle()
             *   
             *   Next byte is the size of of the array of data.
             *   Read off that many arrays, where the beginning of each sub array is prefixed with the size of that sub one.
             */
        }
    }
}
