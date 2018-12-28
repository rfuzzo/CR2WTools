using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventEquipItem : CStorySceneEvent
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

[REDProp("leftItem")]
public CName LeftItem { get; set;}

[REDProp("rightItem")]
public CName RightItem { get; set;}

[REDProp("actor")]
public CName Actor { get; set;}

[REDProp("ignoreItemsWithTag")]
public CName IgnoreItemsWithTag { get; set;}

[REDProp("internalMode")]
public ESceneItemEventMode InternalMode { get; set;}

[REDProp("instant")]
public bool Instant { get; set;}

#endregion
}
}