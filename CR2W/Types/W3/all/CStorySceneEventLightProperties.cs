using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventLightProperties : CStorySceneEvent
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

[REDProp("lightId")]
public CName LightId { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("additiveChanges")]
public bool AdditiveChanges { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("lightColorSource")]
public ESceneEventLightColorSource LightColorSource { get; set;}

[REDProp("radius")]
public SSimpleCurve Radius { get; set;}

[REDProp("brightness")]
public SSimpleCurve Brightness { get; set;}

[REDProp("attenuation")]
public SSimpleCurve Attenuation { get; set;}

[REDProp("placement")]
public EngineTransform Placement { get; set;}

[REDProp("flickering")]
public SLightFlickering Flickering { get; set;}

[REDProp("useGlobalCoords")]
public bool UseGlobalCoords { get; set;}

[REDProp("spotLightProperties")]
public SStorySceneSpotLightProperties SpotLightProperties { get; set;}

[REDProp("dimmerProperties")]
public SStorySceneLightDimmerProperties DimmerProperties { get; set;}

[REDProp("attachment")]
public SStorySceneAttachmentInfo Attachment { get; set;}

[REDProp("lightTracker")]
public SStorySceneLightTrackingInfo LightTracker { get; set;}

#endregion
}
}