using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CGrassOccurrenceMap : CObject
{
#region RED Properties

[REDProp("cellMasks")]
public Array<CGrassCellMask> CellMasks { get; set;}

#endregion
}
}