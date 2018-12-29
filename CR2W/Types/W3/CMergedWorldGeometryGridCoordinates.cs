using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMergedWorldGeometryGridCoordinates 
{
#region RED Properties

[REDProp("x")]
public Int16 X { get; set;}

[REDProp("y")]
public Int16 Y { get; set;}

#endregion
}
}