using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SAreaEnvironmentPoint 
{
#region RED Properties

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("direction")]
public EulerAngles Direction { get; set;}

[REDProp("type")]
public EAreaEnvironmentPointType Type { get; set;}

[REDProp("blend")]
public EAreaEnvironmentPointBlend Blend { get; set;}

[REDProp("innerRadius")]
public float InnerRadius { get; set;}

[REDProp("outerRadius")]
public float OuterRadius { get; set;}

[REDProp("scaleX")]
public float ScaleX { get; set;}

[REDProp("scaleY")]
public float ScaleY { get; set;}

[REDProp("scaleZ")]
public float ScaleZ { get; set;}

[REDProp("useCurve")]
public bool UseCurve { get; set;}

[REDProp("curve")]
public SSimpleCurve Curve { get; set;}

[REDProp("blendScale")]
public float BlendScale { get; set;}

[REDProp("environmentDefinition")]
public Handle<CEnvironmentDefinition> EnvironmentDefinition { get; set;}

#endregion
}
}