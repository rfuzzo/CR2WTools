using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAISirenDynamicWander : CAISubTree
{
#region RED Properties

[REDProp("chanceToTakeOff")]
public float ChanceToTakeOff { get; set;}

[REDProp("chanceToLand")]
public float ChanceToLand { get; set;}

[REDProp("chanceToDive")]
public float ChanceToDive { get; set;}

[REDProp("minFlyDistance")]
public float MinFlyDistance { get; set;}

[REDProp("maxFlyDistance")]
public float MaxFlyDistance { get; set;}

[REDProp("minHeight")]
public float MinHeight { get; set;}

[REDProp("maxHeight")]
public float MaxHeight { get; set;}

[REDProp("proximityToAllowTakeOff")]
public float ProximityToAllowTakeOff { get; set;}

[REDProp("proximityToForceTakeOff")]
public float ProximityToForceTakeOff { get; set;}

[REDProp("distanceFromPlayerToLand")]
public float DistanceFromPlayerToLand { get; set;}

#endregion
}
}