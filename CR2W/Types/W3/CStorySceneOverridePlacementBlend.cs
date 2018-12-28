using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneOverridePlacementBlend : CStorySceneEventCurveBlend
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

[REDProp("keys")]
public Array<CGUID> Keys { get; set;}

[REDProp("curve")]
public SMultiCurve Curve { get; set;}

[REDProp("actorName")]
public CName ActorName { get; set;}

[REDProp("animationStartName")]
public CName AnimationStartName { get; set;}

[REDProp("animationLoopName")]
public CName AnimationLoopName { get; set;}

[REDProp("animationStopName")]
public CName AnimationStopName { get; set;}

#endregion
}
}