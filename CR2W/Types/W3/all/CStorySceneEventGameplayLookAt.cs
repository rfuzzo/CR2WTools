using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventGameplayLookAt : CStorySceneEventDuration
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

[REDProp("target")]
public CName Target { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("instant")]
public bool Instant { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("staticPoint")]
public Vector StaticPoint { get; set;}

[REDProp("type")]
public EDialogLookAtType Type { get; set;}

[REDProp("useWeightCurve")]
public bool UseWeightCurve { get; set;}

[REDProp("weightCurve")]
public SCurveData WeightCurve { get; set;}

[REDProp("behaviorVarWeight")]
public CName BehaviorVarWeight { get; set;}

[REDProp("behaviorVarTarget")]
public CName BehaviorVarTarget { get; set;}

#endregion
}
}