using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventLightPropertiesInterpolation : CStorySceneEventInterpolation
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

[REDProp("keyGuids")]
public Array<CGUID> KeyGuids { get; set;}

[REDProp("interpolationMethod")]
public EInterpolationMethod InterpolationMethod { get; set;}

[REDProp("easeInStyle")]
public EInterpolationEasingStyle EaseInStyle { get; set;}

[REDProp("easeInParameter")]
public float EaseInParameter { get; set;}

[REDProp("easeOutStyle")]
public EInterpolationEasingStyle EaseOutStyle { get; set;}

[REDProp("easeOutParameter")]
public float EaseOutParameter { get; set;}

[REDProp("keys")]
public Array<CStorySceneEventLightPropertiesInterpolationKey> Keys { get; set;}

#endregion
}
}