using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneEventOverrideAnimation : CStorySceneEventAnimation
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

[REDProp("animationName")]
public CName AnimationName { get; set;}

[REDProp("useMotionExtraction")]
public bool UseMotionExtraction { get; set;}

[REDProp("useFakeMotion")]
public bool UseFakeMotion { get; set;}

[REDProp("gatherSyncTokens")]
public bool GatherSyncTokens { get; set;}

[REDProp("muteSoundEvents")]
public bool MuteSoundEvents { get; set;}

[REDProp("disableLookAt")]
public bool DisableLookAt { get; set;}

[REDProp("disableLookAtSpeed")]
public float DisableLookAtSpeed { get; set;}

[REDProp("useLowerBodyPartsForLookAt")]
public bool UseLowerBodyPartsForLookAt { get; set;}

[REDProp("bonesIdx")]
public Array<Int32> BonesIdx { get; set;}

[REDProp("bonesWeight")]
public Array<float> BonesWeight { get; set;}

[REDProp("animationType")]
public EStorySceneAnimationType AnimationType { get; set;}

[REDProp("addConvertToAdditive")]
public bool AddConvertToAdditive { get; set;}

[REDProp("addAdditiveType")]
public EAdditiveType AddAdditiveType { get; set;}

[REDProp("useWeightCurve")]
public bool UseWeightCurve { get; set;}

[REDProp("weightCurve")]
public SCurveData WeightCurve { get; set;}

[REDProp("weightCurveChanged")]
public bool WeightCurveChanged { get; set;}

[REDProp("supportsMotionExClipFront")]
public bool SupportsMotionExClipFront { get; set;}

[REDProp("fakeProp")]
public bool FakeProp { get; set;}

#endregion
}
}