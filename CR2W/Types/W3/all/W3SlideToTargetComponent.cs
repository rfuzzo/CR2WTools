using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SlideToTargetComponent : CSelfUpdatingComponent
{
#region RED Properties

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("stopDistance")]
public float StopDistance { get; set;}

[REDProp("targetOffset")]
public Vector TargetOffset { get; set;}

[REDProp("fallBackSpeed")]
public float FallBackSpeed { get; set;}

[REDProp("snapToGround")]
public bool SnapToGround { get; set;}

[REDProp("normalSpeed")]
public float NormalSpeed { get; set;}

[REDProp("verticalSpeed")]
public float VerticalSpeed { get; set;}

[REDProp("speedOscilation")]
public SRangeF SpeedOscilation { get; set;}

[REDProp("normalSpeedOscilation")]
public SRangeF NormalSpeedOscilation { get; set;}

[REDProp("verticalOscilation")]
public SRangeF VerticalOscilation { get; set;}

[REDProp("speedOscilationSpeed")]
public float SpeedOscilationSpeed { get; set;}

[REDProp("normalSpeedOscilationSpeed")]
public float NormalSpeedOscilationSpeed { get; set;}

[REDProp("verticalOscilationSpeed")]
public float VerticalOscilationSpeed { get; set;}

[REDProp("gameplayEventAtDestination")]
public CName GameplayEventAtDestination { get; set;}

[REDProp("triggerGPEventOnTarget")]
public bool TriggerGPEventOnTarget { get; set;}

[REDProp("destroyDelayAtDestination")]
public float DestroyDelayAtDestination { get; set;}

[REDProp("stopEffectAtDest")]
public CName StopEffectAtDest { get; set;}

[REDProp("playEffectAtDest")]
public CName PlayEffectAtDest { get; set;}

[REDProp("stayAboveNavigableSpace")]
public bool StayAboveNavigableSpace { get; set;}

[REDProp("considerSuccesAfterDelay")]
public float ConsiderSuccesAfterDelay { get; set;}

[REDProp("m_NodeTarget")]
public Handle<CNode> M_NodeTarget { get; set;}

[REDProp("m_VectorTarget")]
public Vector M_VectorTarget { get; set;}

[REDProp("m_IsFallingBack")]
public bool M_IsFallingBack { get; set;}

[REDProp("m_Entity")]
public Handle<CEntity> M_Entity { get; set;}

[REDProp("m_CanSendEvent")]
public bool M_CanSendEvent { get; set;}

[REDProp("m_TimeBeforeSuccess")]
public float M_TimeBeforeSuccess { get; set;}

[REDProp("m_speedTarget")]
public float M_speedTarget { get; set;}

[REDProp("m_normalSpeedTarget")]
public float M_normalSpeedTarget { get; set;}

[REDProp("m_verticalOffsetTarget")]
public float M_verticalOffsetTarget { get; set;}

[REDProp("m_currentSpeedOsc")]
public float M_currentSpeedOsc { get; set;}

[REDProp("m_currentNormalSpeedOsc")]
public float M_currentNormalSpeedOsc { get; set;}

[REDProp("m_currentVertOffest")]
public float M_currentVertOffest { get; set;}

#endregion
}
}