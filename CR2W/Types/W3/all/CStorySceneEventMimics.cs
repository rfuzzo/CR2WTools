using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventMimics : CStorySceneEventAnimClip
{
#region RED Properties

[REDProp("eventName")]
public string EventName { get; set;}

[REDProp("startPosition")]
public float StartPosition { get; set;}

[REDProp("isMuted")]
public bool IsMuted { get; set;}

[REDProp("contexID")]
public int ContexID { get; set;}

[REDProp("sceneElement")]
public Ptr<CStorySceneElement> SceneElement { get; set;}

[REDProp("GUID")]
public CGUID GUID { get; set;}

[REDProp("interpolationEventGUID")]
public CGUID InterpolationEventGUID { get; set;}

[REDProp("blendParentGUID")]
public CGUID BlendParentGUID { get; set;}

[REDProp("linkParentGUID")]
public CGUID LinkParentGUID { get; set;}

[REDProp("linkParentTimeOffset")]
public float LinkParentTimeOffset { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("actor")]
public CName Actor { get; set;}

[REDProp("blendIn")]
public float BlendIn { get; set;}

[REDProp("blendOut")]
public float BlendOut { get; set;}

[REDProp("clipFront")]
public float ClipFront { get; set;}

[REDProp("clipEnd")]
public float ClipEnd { get; set;}

[REDProp("stretch")]
public float Stretch { get; set;}

[REDProp("allowLookatsLevel")]
public ELookAtLevel AllowLookatsLevel { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("forceAnimationTimeFlag")]
public bool ForceAnimationTimeFlag { get; set;}

[REDProp("forceAnimationTime")]
public float ForceAnimationTime { get; set;}

[REDProp("voiceWeightCurve")]
public SVoiceWeightCurve VoiceWeightCurve { get; set;}

[REDProp("allowPoseCorrection")]
public bool AllowPoseCorrection { get; set;}

[REDProp("stateName")]
public CName StateName { get; set;}

[REDProp("mimicsEmotionalState")]
public CName MimicsEmotionalState { get; set;}

[REDProp("mimicsLayer_Eyes")]
public CName MimicsLayer_Eyes { get; set;}

[REDProp("mimicsLayer_Pose")]
public CName MimicsLayer_Pose { get; set;}

[REDProp("mimicsLayer_Animation")]
public CName MimicsLayer_Animation { get; set;}

[REDProp("mimicsPoseWeight")]
public float MimicsPoseWeight { get; set;}

[REDProp("transitionAnimation")]
public CName TransitionAnimation { get; set;}

[REDProp("forceMimicsIdleAnimation_Eyes")]
public CName ForceMimicsIdleAnimation_Eyes { get; set;}

[REDProp("forceMimicsIdleAnimation_Pose")]
public CName ForceMimicsIdleAnimation_Pose { get; set;}

[REDProp("forceMimicsIdleAnimation_Animation")]
public CName ForceMimicsIdleAnimation_Animation { get; set;}

[REDProp("useWeightCurve")]
public bool UseWeightCurve { get; set;}

[REDProp("weightCurve")]
public SCurveData WeightCurve { get; set;}

#endregion
}
}