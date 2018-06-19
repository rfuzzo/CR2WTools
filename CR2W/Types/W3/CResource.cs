using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    /// <summary>
    /// Represents a Witcher 3 resource that that can be read by the REDEngine3.
    /// </summary>
    public abstract class CResource : CObject
    {
        public string GetPath()
        {
            throw new NotImplementedException();
        }
    }
}
