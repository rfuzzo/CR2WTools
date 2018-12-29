using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSCDistanceToTarget : IMoveSteeringCondition
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

#endregion
}
}