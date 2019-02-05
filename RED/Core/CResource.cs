using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RED.Core
{
    /// <summary>
    /// Provides a base abstract class that is used for all resource files.
    /// </summary>
    public abstract class CResource : CObject
    {
        [RED] private protected string importFile;
        [RED] private protected CDateTime importFileTimeStamp;

        public string ImportFile
        {
            get => importFile;
            set => importFile = value;
        }
        public CDateTime ImportFileTimeStamp
        {
            get => importFileTimeStamp;
            set => importFileTimeStamp = value;
        }

        public string GetPath()
        {
            throw new NotImplementedException();
        }

        public void SaveResource()
        {

        }
    }
}
