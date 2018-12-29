using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3BackgroundAnimatedEntity : CGameplayEntity
{
#region RED Properties

[REDProp("backgroundEntityData")]
public Array<SBackgroundEntityData> BackgroundEntityData { get; set;}

[REDProp("parentEntity")]
public Handle<CEntityTemplate> ParentEntity { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

[REDProp("acceleration")]
public float Acceleration { get; set;}

[REDProp("maxAngleSpeed")]
public float MaxAngleSpeed { get; set;}

[REDProp("waypointDistance")]
public float WaypointDistance { get; set;}

[REDProp("waypoints")]
public Array<EntityHandle> Waypoints { get; set;}

[REDProp("loopMotion")]
public bool LoopMotion { get; set;}

[REDProp("startAtSpawn")]
public bool StartAtSpawn { get; set;}

[REDProp("maxAngleSpeedThreshold")]
public float MaxAngleSpeedThreshold { get; set;}

[REDProp("angleAcceleration")]
public float AngleAcceleration { get; set;}

[REDProp("stoppingDistance")]
public float StoppingDistance { get; set;}

[REDProp("endPositionError")]
public float EndPositionError { get; set;}

[REDProp("angleSpeed")]
public float AngleSpeed { get; set;}

[REDProp("speedScale")]
public float SpeedScale { get; set;}

[REDProp("previousAngleDistance")]
public float PreviousAngleDistance { get; set;}

[REDProp("nodes")]
public Array<Handle<CNode>> Nodes { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("size")]
public Int32 Size { get; set;}

[REDProp("currTargetIndex")]
public Int32 CurrTargetIndex { get; set;}

[REDProp("canMove")]
public bool CanMove { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("entityToAttach")]
public Handle<CEntity> EntityToAttach { get; set;}

[REDProp("currTarget")]
public Handle<CNode> CurrTarget { get; set;}

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("currPosition")]
public Vector CurrPosition { get; set;}

[REDProp("direction")]
public Vector Direction { get; set;}

[REDProp("toTarget")]
public Vector ToTarget { get; set;}

[REDProp("angleDistancePlus")]
public float AngleDistancePlus { get; set;}

[REDProp("angleDistanceMinus")]
public float AngleDistanceMinus { get; set;}

[REDProp("angleDistance")]
public float AngleDistance { get; set;}

[REDProp("distanceToTarget")]
public float DistanceToTarget { get; set;}

[REDProp("rotation")]
public EulerAngles Rotation { get; set;}

[REDProp("desiredRotation")]
public EulerAngles DesiredRotation { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("shouldStop")]
public bool ShouldStop { get; set;}

[REDProp("maxCurrentAngleSpeed")]
public float MaxCurrentAngleSpeed { get; set;}

[REDProp("maxCurrentSpeed")]
public float MaxCurrentSpeed { get; set;}

#endregion
}
}