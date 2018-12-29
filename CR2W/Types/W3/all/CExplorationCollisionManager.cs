using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationCollisionManager : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("m_CollideWithNPCEventCenter")]
public CName M_CollideWithNPCEventCenter { get; set;}

[REDProp("m_CollideWithNPCEventLeft")]
public CName M_CollideWithNPCEventLeft { get; set;}

[REDProp("m_CollideWithNPCEventRight")]
public CName M_CollideWithNPCEventRight { get; set;}

[REDProp("m_CollideNameS")]
public CName M_CollideNameS { get; set;}

[REDProp("m_CollideBehGraphSideNameS")]
public CName M_CollideBehGraphSideNameS { get; set;}

[REDProp("m_CollideBehGraphStanceNameS")]
public CName M_CollideBehGraphStanceNameS { get; set;}

[REDProp("m_CollideAngleNameS")]
public CName M_CollideAngleNameS { get; set;}

[REDProp("m_CollideBehGraphStrengthRelNameS")]
public CName M_CollideBehGraphStrengthRelNameS { get; set;}

[REDProp("m_CollideBehGraphHeightN")]
public CName M_CollideBehGraphHeightN { get; set;}

[REDProp("m_CanCollideWithStaticaB")]
public bool M_CanCollideWithStaticaB { get; set;}

[REDProp("m_VisualReactionToPushB")]
public bool M_VisualReactionToPushB { get; set;}

[REDProp("m_SpeedToCollideWihNPCsF")]
public float M_SpeedToCollideWihNPCsF { get; set;}

[REDProp("m_TimeCollidingToStopF")]
public float M_TimeCollidingToStopF { get; set;}

[REDProp("m_TimeCollidingCurF")]
public float M_TimeCollidingCurF { get; set;}

[REDProp("m_AcceptableZToBumpF")]
public float M_AcceptableZToBumpF { get; set;}

[REDProp("playerHandHeightRange")]
public float PlayerHandHeightRange { get; set;}

[REDProp("m_LandWaterMinDepthF")]
public float M_LandWaterMinDepthF { get; set;}

[REDProp("m_CollisionGroupsNamesNArr")]
public Array<CName> M_CollisionGroupsNamesNArr { get; set;}

[REDProp("m_CollisionSightNArr")]
public Array<CName> M_CollisionSightNArr { get; set;}

[REDProp("m_CollisionObstaclesNArr")]
public Array<CName> M_CollisionObstaclesNArr { get; set;}

[REDProp("m_CollidingB")]
public bool M_CollidingB { get; set;}

[REDProp("m_IsThereAnyCollisionB")]
public bool M_IsThereAnyCollisionB { get; set;}

[REDProp("m_CollidingWithNpcB")]
public bool M_CollidingWithNpcB { get; set;}

[REDProp("m_CollidingWithStaticsB")]
public bool M_CollidingWithStaticsB { get; set;}

[REDProp("m_AngleToSideF")]
public float M_AngleToSideF { get; set;}

[REDProp("m_CollidingAngleF")]
public float M_CollidingAngleF { get; set;}

[REDProp("m_CollideCenterIfBothSidesB")]
public bool M_CollideCenterIfBothSidesB { get; set;}

[REDProp("m_CollidingSideE")]
public ESideSelected M_CollidingSideE { get; set;}

[REDProp("m_CollidingSideLastE")]
public ESideSelected M_CollidingSideLastE { get; set;}

[REDProp("m_CollidingSideCooldownF")]
public float M_CollidingSideCooldownF { get; set;}

[REDProp("forceFallEnabled")]
public bool ForceFallEnabled { get; set;}

[REDProp("forceFallRequireCenter")]
public bool ForceFallRequireCenter { get; set;}

[REDProp("forceFallRunning")]
public bool ForceFallRunning { get; set;}

[REDProp("m_CollidingStrengthOtherF")]
public float M_CollidingStrengthOtherF { get; set;}

[REDProp("m_CollidingStrengthRelativeF")]
public float M_CollidingStrengthRelativeF { get; set;}

[REDProp("m_CollidingDirOtherV")]
public Vector M_CollidingDirOtherV { get; set;}

[REDProp("m_CollidingSpeedOtherV")]
public Vector M_CollidingSpeedOtherV { get; set;}

[REDProp("m_CollidingStrengthFadeSpeedF")]
public float M_CollidingStrengthFadeSpeedF { get; set;}

[REDProp("m_CollidingIsLowB")]
public bool M_CollidingIsLowB { get; set;}

[REDProp("m_CollidingLowMinHeightF")]
public float M_CollidingLowMinHeightF { get; set;}

[REDProp("debugEnabled")]
public bool DebugEnabled { get; set;}

[REDProp("m_UpV")]
public Vector M_UpV { get; set;}

[REDProp("m_ZeroV")]
public Vector M_ZeroV { get; set;}

[REDProp("lastWaterCheckPoint")]
public Vector LastWaterCheckPoint { get; set;}

#endregion
}
}