using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateAirCollision : CExplorationStateAbstract
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("speedMinToCollide")]
public float SpeedMinToCollide { get; set;}

[REDProp("heightMinToCollide")]
public float HeightMinToCollide { get; set;}

[REDProp("heightMaxToStop")]
public float HeightMaxToStop { get; set;}

[REDProp("dotToHardHit")]
public float DotToHardHit { get; set;}

[REDProp("collisionAngle")]
public float CollisionAngle { get; set;}

[REDProp("collisionSide")]
public EAirCollisionSide CollisionSide { get; set;}

[REDProp("m_NormalMaxZToHitF")]
public float M_NormalMaxZToHitF { get; set;}

[REDProp("angleMinToCollide")]
public float AngleMinToCollide { get; set;}

[REDProp("angleMinToCollideFront")]
public float AngleMinToCollideFront { get; set;}

[REDProp("swipeDistance")]
public float SwipeDistance { get; set;}

[REDProp("swipeRadius")]
public float SwipeRadius { get; set;}

[REDProp("swipeHeightRequired")]
public float SwipeHeightRequired { get; set;}

[REDProp("timeStopped")]
public float TimeStopped { get; set;}

[REDProp("timeToRotate")]
public float TimeToRotate { get; set;}

[REDProp("timeToCheckClimb")]
public float TimeToCheckClimb { get; set;}

[REDProp("timeToCheckLand")]
public float TimeToCheckLand { get; set;}

[REDProp("exitAngleLeft")]
public float ExitAngleLeft { get; set;}

[REDProp("exitAngleRight")]
public float ExitAngleRight { get; set;}

[REDProp("exitAngleExtra")]
public float ExitAngleExtra { get; set;}

[REDProp("orientingSpeed")]
public float OrientingSpeed { get; set;}

[REDProp("targetYaw")]
public float TargetYaw { get; set;}

[REDProp("verticalSpeedConserveCoef")]
public float VerticalSpeedConserveCoef { get; set;}

[REDProp("verticalMovementParams")]
public SVerticalMovementParams VerticalMovementParams { get; set;}

[REDProp("impulseForwardCenter")]
public float ImpulseForwardCenter { get; set;}

[REDProp("impulseDownCenter")]
public float ImpulseDownCenter { get; set;}

[REDProp("impulseForwardSide")]
public float ImpulseForwardSide { get; set;}

[REDProp("impulseDownSide")]
public float ImpulseDownSide { get; set;}

[REDProp("interactAlways")]
public bool InteractAlways { get; set;}

[REDProp("interactionTimeMin")]
public float InteractionTimeMin { get; set;}

[REDProp("interactionMaxHeight")]
public float InteractionMaxHeight { get; set;}

[REDProp("timeToHitToLand")]
public float TimeToHitToLand { get; set;}

[REDProp("behEventHitToLand")]
public CName BehEventHitToLand { get; set;}

[REDProp("behVarSide")]
public CName BehVarSide { get; set;}

[REDProp("behVarHands")]
public CName BehVarHands { get; set;}

[REDProp("behAnimCanFall")]
public CName BehAnimCanFall { get; set;}

#endregion
}
}