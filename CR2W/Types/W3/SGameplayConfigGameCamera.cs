using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SGameplayConfigGameCamera 
{
#region RED Properties

[REDProp("verManualMax")]
public float VerManualMax { get; set;}

[REDProp("verManualMin")]
public float VerManualMin { get; set;}

[REDProp("horDamping")]
public float HorDamping { get; set;}

[REDProp("verDamping")]
public float VerDamping { get; set;}

[REDProp("pivotDamp")]
public float PivotDamp { get; set;}

[REDProp("focusTargetDamp")]
public float FocusTargetDamp { get; set;}

[REDProp("focusActDuration")]
public float FocusActDuration { get; set;}

[REDProp("zoomDamp")]
public float ZoomDamp { get; set;}

[REDProp("zoomActTime")]
public float ZoomActTime { get; set;}

[REDProp("verOffsetDamp")]
public float VerOffsetDamp { get; set;}

[REDProp("verOffsetActTime")]
public float VerOffsetActTime { get; set;}

[REDProp("backOffsetDamp")]
public float BackOffsetDamp { get; set;}

[REDProp("collisionDampOn")]
public float CollisionDampOn { get; set;}

[REDProp("collisionDampOff")]
public float CollisionDampOff { get; set;}

[REDProp("collisionBigRadius")]
public float CollisionBigRadius { get; set;}

[REDProp("collisionBoxScale")]
public float CollisionBoxScale { get; set;}

[REDProp("collisionAutoRotDamp")]
public float CollisionAutoRotDamp { get; set;}

[REDProp("collisionAutoRotMaxSpeed")]
public float CollisionAutoRotMaxSpeed { get; set;}

[REDProp("collisionVerCorrection")]
public float CollisionVerCorrection { get; set;}

[REDProp("collisionPivotHeightOffset")]
public float CollisionPivotHeightOffset { get; set;}

[REDProp("collisionPivotRadius")]
public float CollisionPivotRadius { get; set;}

[REDProp("collisionVerRadius")]
public float CollisionVerRadius { get; set;}

[REDProp("collisionVerOffsetP")]
public float CollisionVerOffsetP { get; set;}

[REDProp("collisionVerOffsetM")]
public float CollisionVerOffsetM { get; set;}

[REDProp("collisionVerFactor")]
public float CollisionVerFactor { get; set;}

[REDProp("collisionVerRadiusP")]
public float CollisionVerRadiusP { get; set;}

[REDProp("collisionVerRadiusM")]
public float CollisionVerRadiusM { get; set;}

[REDProp("collisionAutoRotTrace")]
public bool CollisionAutoRotTrace { get; set;}

[REDProp("collisionAutoRotTraceFactor")]
public float CollisionAutoRotTraceFactor { get; set;}

[REDProp("indoorCollisionMaxZoom")]
public float IndoorCollisionMaxZoom { get; set;}

[REDProp("slopeVerFactor")]
public float SlopeVerFactor { get; set;}

[REDProp("slopeVerDamp")]
public float SlopeVerDamp { get; set;}

[REDProp("sensX")]
public float SensX { get; set;}

[REDProp("sensY")]
public float SensY { get; set;}

#endregion
}
}