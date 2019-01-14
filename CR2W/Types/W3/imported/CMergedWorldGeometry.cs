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
public class CMergedWorldGeometry : CObject
{
#region RED Properties

[REDProp("gridSize")]
public Int32 GridSize { get; set;}

[REDProp("mergers", 2,0)]
public Array<Ptr<IMergedWorldGeometryData>> Mergers { get; set;}

#endregion
}
}