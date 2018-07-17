using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
    public class CLayer : CResource
    {
        #region RED Properties

        [REDProp("entities", 32, 0)]
        public Array<Ptr<CEntity>> Entities { get; set; }

        [REDProp("sectorData")]
        public Handle<CSectorData> SectorData { get; set; }

        [REDProp("nameCount")]
        public UInt32 NameCount { get; set; }

        #endregion
    }
}
