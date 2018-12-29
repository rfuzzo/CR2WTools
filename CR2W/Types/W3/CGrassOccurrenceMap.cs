using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CGrassOccurrenceMap : CObject
{
#region RED Properties

[REDProp("cellMasks")]
public Array<CGrassCellMask> CellMasks { get; set;}

#endregion
}
}