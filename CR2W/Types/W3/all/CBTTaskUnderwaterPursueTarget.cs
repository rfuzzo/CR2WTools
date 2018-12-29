using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskUnderwaterPursueTarget : IBehTreeTask
{
#region RED Properties

[REDProp("useCustom")]
public bool UseCustom { get; set;}

[REDProp("distanceFromTarget")]
public float DistanceFromTarget { get; set;}

[REDProp("heightFromTarget")]
public float HeightFromTarget { get; set;}

[REDProp("distanceTolerance")]
public float DistanceTolerance { get; set;}

[REDProp("npcPosition")]
public Vector NpcPosition { get; set;}

[REDProp("targetPosition")]
public Vector TargetPosition { get; set;}

[REDProp("npcToTargetDistance2D")]
public float NpcToTargetDistance2D { get; set;}

[REDProp("movePos")]
public Vector MovePos { get; set;}

[REDProp("cachedTime")]
public float CachedTime { get; set;}

[REDProp("randomHeight")]
public Int32 RandomHeight { get; set;}

[REDProp("flySpeed")]
public float FlySpeed { get; set;}

#endregion
}
}