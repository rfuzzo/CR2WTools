using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGrassOccurrenceMap : CObject
{
#region RED Properties

[REDProp("cellMasks", 2,0)]
public Array<CGrassCellMask> CellMasks { get; set;}

#endregion
}
}