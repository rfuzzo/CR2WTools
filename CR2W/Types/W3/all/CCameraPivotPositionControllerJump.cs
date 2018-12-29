using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraPivotPositionControllerJump : ICustomCameraScriptedPivotPositionController
{
#region RED Properties

[REDProp("useExactCamera")]
public bool UseExactCamera { get; set;}

[REDProp("originalOffset")]
public Vector OriginalOffset { get; set;}

[REDProp("zOffset")]
public float ZOffset { get; set;}

[REDProp("originalPosition")]
public Vector OriginalPosition { get; set;}

[REDProp("originalHeight")]
public float OriginalHeight { get; set;}

[REDProp("blendXYSpeed")]
public float BlendXYSpeed { get; set;}

[REDProp("blendXYSpeedWithTime")]
public bool BlendXYSpeedWithTime { get; set;}

[REDProp("blendXYSpeedTimeStart")]
public float BlendXYSpeedTimeStart { get; set;}

[REDProp("blendXYSpeedTimeEnd")]
public float BlendXYSpeedTimeEnd { get; set;}

[REDProp("blendXYSpeedMin")]
public float BlendXYSpeedMin { get; set;}

[REDProp("blendXYSpeedMax")]
public float BlendXYSpeedMax { get; set;}

[REDProp("blendZSpeedStart")]
public float BlendZSpeedStart { get; set;}

[REDProp("blendZSpeedEnd")]
public float BlendZSpeedEnd { get; set;}

[REDProp("blendCurve")]
public Handle<CCurve> BlendCurve { get; set;}

[REDProp("blendZBasedOn")]
public ECameraBlendSpeedMode BlendZBasedOn { get; set;}

[REDProp("blendZHeightMaxDif")]
public float BlendZHeightMaxDif { get; set;}

[REDProp("blendZDistToForceStart")]
public float BlendZDistToForceStart { get; set;}

[REDProp("blendZDistToForceEnd")]
public float BlendZDistToForceEnd { get; set;}

[REDProp("blendZDistToForceMaxCur")]
public float BlendZDistToForceMaxCur { get; set;}

[REDProp("blendZSpeedTimeMin")]
public float BlendZSpeedTimeMin { get; set;}

[REDProp("blendZSpeedTimeTotal")]
public float BlendZSpeedTimeTotal { get; set;}

[REDProp("blendZSpeedTimeCur")]
public float BlendZSpeedTimeCur { get; set;}

[REDProp("addOffset")]
public bool AddOffset { get; set;}

[REDProp("verticalDownOffsetMax")]
public float VerticalDownOffsetMax { get; set;}

[REDProp("verticalDownTimeMax")]
public float VerticalDownTimeMax { get; set;}

[REDProp("verticalDownTimeMin")]
public float VerticalDownTimeMin { get; set;}

[REDProp("isInInterior")]
public bool IsInInterior { get; set;}

[REDProp("blendZInteriorTimeToFall")]
public float BlendZInteriorTimeToFall { get; set;}

[REDProp("blendZSpeedInterior")]
public float BlendZSpeedInterior { get; set;}

[REDProp("blendZSpeedInteriorFall")]
public float BlendZSpeedInteriorFall { get; set;}

[REDProp("heightTraceAlwaysAdjust")]
public bool HeightTraceAlwaysAdjust { get; set;}

[REDProp("heightTraceEnabled")]
public bool HeightTraceEnabled { get; set;}

[REDProp("heightTraceDownMax")]
public float HeightTraceDownMax { get; set;}

[REDProp("heightTraceTotalAdded")]
public float HeightTraceTotalAdded { get; set;}

[REDProp("heightTraceAccumulated")]
public float HeightTraceAccumulated { get; set;}

[REDProp("heightTraceMax")]
public float HeightTraceMax { get; set;}

[REDProp("heightTraceTotal")]
public float HeightTraceTotal { get; set;}

[REDProp("heightTraceSpeed")]
public float HeightTraceSpeed { get; set;}

[REDProp("heightTraceSpeedDownMin")]
public float HeightTraceSpeedDownMin { get; set;}

[REDProp("heightTraceSpeedDownMax")]
public float HeightTraceSpeedDownMax { get; set;}

[REDProp("heightTraceCollFlags")]
public Array<CName> HeightTraceCollFlags { get; set;}

[REDProp("heightTraceCollFlagsInit")]
public bool HeightTraceCollFlagsInit { get; set;}

[REDProp("heightTraceDown")]
public bool HeightTraceDown { get; set;}

[REDProp("heightTraceDownTimeMin")]
public float HeightTraceDownTimeMin { get; set;}

[REDProp("heightTraceDownTimeMax")]
public float HeightTraceDownTimeMax { get; set;}

[REDProp("traceForwardExtraOffset")]
public float TraceForwardExtraOffset { get; set;}

[REDProp("heightTraceAdjusting")]
public bool HeightTraceAdjusting { get; set;}

[REDProp("heightAdjustingTime")]
public float HeightAdjustingTime { get; set;}

[REDProp("boneFollowName")]
public CName BoneFollowName { get; set;}

[REDProp("boneFollow")]
public Int32 BoneFollow { get; set;}

[REDProp("startFollowBoneTime")]
public float StartFollowBoneTime { get; set;}

[REDProp("followBoneOnFall")]
public bool FollowBoneOnFall { get; set;}

[REDProp("falling")]
public bool Falling { get; set;}

[REDProp("forceOnGround")]
public bool ForceOnGround { get; set;}

[REDProp("debugLog")]
public bool DebugLog { get; set;}

[REDProp("zeroVector")]
public Vector ZeroVector { get; set;}

#endregion
}
}