using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SQuestMapPinInfo 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("type")]
public CName Type { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("positions")]
public Array<Vector> Positions { get; set;}

#endregion
}
}