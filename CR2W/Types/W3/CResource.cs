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
        public CDateTime TimeStamp { get; private set; }

        private string m_path;

        public string GetPath()
        {
            return m_path;
        }

        public void SetPath( string path )
        {
            m_path = path;
        }
    }
}
