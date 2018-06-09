using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;

namespace CR2W.Types
{
    public interface IReferencable
    {
        void ParseBytes(CR2WBinaryReader parser, uint size);
    }
}
