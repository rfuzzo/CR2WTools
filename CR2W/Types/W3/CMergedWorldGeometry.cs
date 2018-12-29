using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMergedWorldGeometry : CObject
{
#region RED Properties

[REDProp("gridSize")]
public int GridSize { get; set;}

[REDProp("mergers")]
public Array<Ptr<IMergedWorldGeometryData>> Mergers { get; set;}

#endregion
}
}