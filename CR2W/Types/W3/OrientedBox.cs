using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class OrientedBox 
{
#region RED Properties

[REDProp("position")]
public Vector Position { get; set;}

/*[REDProp("edge 1")]
public Vector Edge 1 { get; set;}

[REDProp("edge 2")]
public Vector Edge 2 { get; set;}*/

#endregion
}
}