using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStorySceneLight : IStorySceneItem
{
#region RED Properties

[REDProp("id")]
public CName Id { get; set;}

[REDProp("type")]
public ELightType Type { get; set;}

[REDProp("innerAngle")]
public float InnerAngle { get; set;}

[REDProp("outerAngle")]
public float OuterAngle { get; set;}

[REDProp("softness")]
public float Softness { get; set;}

[REDProp("shadowCastingMode")]
public ELightShadowCastingMode ShadowCastingMode { get; set;}

[REDProp("shadowFadeDistance")]
public float ShadowFadeDistance { get; set;}

[REDProp("shadowFadeRange")]
public float ShadowFadeRange { get; set;}

[REDProp("dimmerType")]
public EDimmerType DimmerType { get; set;}

[REDProp("dimmerAreaMarker")]
public bool DimmerAreaMarker { get; set;}

#endregion
}
}