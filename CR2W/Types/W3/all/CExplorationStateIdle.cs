using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateIdle : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_SubStateLasE")]
public EPlayerIdleSubstate M_SubStateLasE { get; set;}

[REDProp("m_SubStateE")]
public EPlayerIdleSubstate M_SubStateE { get; set;}

[REDProp("m_SpeedMaxConsideredSprintF")]
public float M_SpeedMaxConsideredSprintF { get; set;}

[REDProp("m_SpeedMaxConsideredRunF")]
public float M_SpeedMaxConsideredRunF { get; set;}

[REDProp("m_SpeedMaxConsideredWalkF")]
public float M_SpeedMaxConsideredWalkF { get; set;}

[REDProp("m_FallSpeedCoefF")]
public float M_FallSpeedCoefF { get; set;}

[REDProp("m_FallExtraVerticalImpulseF")]
public float M_FallExtraVerticalImpulseF { get; set;}

[REDProp("m_FallHorizontalImpulseF")]
public float M_FallHorizontalImpulseF { get; set;}

[REDProp("m_FallHorizontalImpulseCancelF")]
public float M_FallHorizontalImpulseCancelF { get; set;}

[REDProp("m_TimeToSlideNeededF")]
public float M_TimeToSlideNeededF { get; set;}

[REDProp("m_TimeToSlideCurF")]
public float M_TimeToSlideCurF { get; set;}

[REDProp("m_CameraExtraOffsetF")]
public float M_CameraExtraOffsetF { get; set;}

[REDProp("m_CameraOffsetExtraVertLowF")]
public float M_CameraOffsetExtraVertLowF { get; set;}

[REDProp("m_CameraOffsetExtraVertHighF")]
public float M_CameraOffsetExtraVertHighF { get; set;}

[REDProp("m_CameraOffsetBlend")]
public float M_CameraOffsetBlend { get; set;}

[REDProp("m_CameraOffsetVertF")]
public float M_CameraOffsetVertF { get; set;}

[REDProp("m_CurentCameraAnimationN")]
public CName M_CurentCameraAnimationN { get; set;}

[REDProp("m_CameraAnimIdleS")]
public SCameraAnimationData M_CameraAnimIdleS { get; set;}

[REDProp("m_CameraAnimWalkS")]
public SCameraAnimationData M_CameraAnimWalkS { get; set;}

[REDProp("m_CameraAnimRunS")]
public SCameraAnimationData M_CameraAnimRunS { get; set;}

[REDProp("m_CameraAnimSprintS")]
public SCameraAnimationData M_CameraAnimSprintS { get; set;}

#endregion
}
}