using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class Segment 
{
#region RED Properties

[REDProp("origin")]
public Vector Origin { get; set;}

[REDProp("direction")]
public Vector Direction { get; set;}

#endregion
}
}