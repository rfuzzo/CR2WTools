using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventPoseKey : CStorySceneEventDuration
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

[REDProp("weightBlendType")]
public EInterpolationType WeightBlendType { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("useWeightCurve")]
public bool UseWeightCurve { get; set;}

[REDProp("weightCurve")]
public SCurveData WeightCurve { get; set;}

[REDProp("linkToDialogset")]
public bool LinkToDialogset { get; set;}

[REDProp("version")]
public int Version { get; set;}

[REDProp("cachedBones")]
public Array<Int32> CachedBones { get; set;}

[REDProp("cachedTransforms")]
public Array<EngineQsTransform> CachedTransforms { get; set;}

[REDProp("cachedTracks")]
public Array<Int32> CachedTracks { get; set;}

[REDProp("cachedTracksValues")]
public Array<float> CachedTracksValues { get; set;}

#endregion
}
}