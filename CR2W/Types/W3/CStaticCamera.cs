using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStaticCamera : CCamera
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components")]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("solver")]
public ECameraSolver Solver { get; set;}

[REDProp("activationDuration")]
public float ActivationDuration { get; set;}

[REDProp("deactivationDuration")]
public float DeactivationDuration { get; set;}

[REDProp("timeout")]
public float Timeout { get; set;}

[REDProp("zoom")]
public float Zoom { get; set;}

[REDProp("fov")]
public float Fov { get; set;}

[REDProp("animState")]
public int AnimState { get; set;}

[REDProp("guiEffect")]
public int GuiEffect { get; set;}

[REDProp("blockPlayer")]
public bool BlockPlayer { get; set;}

[REDProp("resetPlayerCamera")]
public bool ResetPlayerCamera { get; set;}

[REDProp("fadeStartDuration")]
public float FadeStartDuration { get; set;}

[REDProp("fadeStartColor")]
public Color FadeStartColor { get; set;}

[REDProp("isFadeStartFadeIn")]
public bool IsFadeStartFadeIn { get; set;}

[REDProp("fadeEndDuration")]
public float FadeEndDuration { get; set;}

[REDProp("fadeEndColor")]
public Color FadeEndColor { get; set;}

[REDProp("isFadeEndFadeIn")]
public bool IsFadeEndFadeIn { get; set;}

#endregion
}
}