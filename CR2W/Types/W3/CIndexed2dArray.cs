using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types.W3
{
    public class CIndexed2dArray : C2dArray
    {
        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
