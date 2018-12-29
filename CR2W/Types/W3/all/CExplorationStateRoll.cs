using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateRoll : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_TimeSafetyEndF")]
public float M_TimeSafetyEndF { get; set;}

[REDProp("m_OrientationSpeedF")]
public float M_OrientationSpeedF { get; set;}

[REDProp("m_AutoRollB")]
public bool M_AutoRollB { get; set;}

[REDProp("m_RollMinHeightF")]
public float M_RollMinHeightF { get; set;}

[REDProp("m_RollTimeAfterF")]
public float M_RollTimeAfterF { get; set;}

[REDProp("m_ReadyToEndB")]
public bool M_ReadyToEndB { get; set;}

[REDProp("m_ReadyToFallB")]
public bool M_ReadyToFallB { get; set;}

[REDProp("m_BehLandRunS")]
public CName M_BehLandRunS { get; set;}

[REDProp("m_BehLandCancelN")]
public CName M_BehLandCancelN { get; set;}

[REDProp("m_BehLandCanEndN")]
public CName M_BehLandCanEndN { get; set;}

[REDProp("m_BehLandCanFallN")]
public CName M_BehLandCanFallN { get; set;}

[REDProp("m_SlidingB")]
public bool M_SlidingB { get; set;}

[REDProp("m_SlideTimeToDecideF")]
public float M_SlideTimeToDecideF { get; set;}

[REDProp("m_ToFallB")]
public bool M_ToFallB { get; set;}

[REDProp("verticalMovementParams")]
public SVerticalMovementParams VerticalMovementParams { get; set;}

[REDProp("m_ToSlideB")]
public bool M_ToSlideB { get; set;}

[REDProp("m_TimeBeforeChainJumpF")]
public float M_TimeBeforeChainJumpF { get; set;}

#endregion
}
}