using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class Bezier2dHandle 
{
#region RED Properties

[REDProp("incomingTangent")]
public Vector2 IncomingTangent { get; set;}

[REDProp("outgoingTangent")]
public Vector2 OutgoingTangent { get; set;}

#endregion
}
}