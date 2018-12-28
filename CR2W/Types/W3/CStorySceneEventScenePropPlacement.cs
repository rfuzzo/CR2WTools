using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventScenePropPlacement : CStorySceneEvent
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

[REDProp("propId")]
public CName PropId { get; set;}

[REDProp("placement")]
public EngineTransform Placement { get; set;}

[REDProp("showHide")]
public bool ShowHide { get; set;}

[REDProp("rotationCyclesPitch")]
public uint RotationCyclesPitch { get; set;}

[REDProp("rotationCyclesRoll")]
public uint RotationCyclesRoll { get; set;}

[REDProp("rotationCyclesYaw")]
public uint RotationCyclesYaw { get; set;}

#endregion
}
}