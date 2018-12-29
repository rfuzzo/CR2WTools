using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWanderDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("minSpeed")]
public float MinSpeed { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

#endregion
}
}