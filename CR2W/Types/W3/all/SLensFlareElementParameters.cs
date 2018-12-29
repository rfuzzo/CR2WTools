using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SLensFlareElementParameters 
{
#region RED Properties

[REDProp("material")]
public Handle<CMaterialInstance> Material { get; set;}

[REDProp("isConstRadius")]
public bool IsConstRadius { get; set;}

[REDProp("isAligned")]
public bool IsAligned { get; set;}

[REDProp("centerFadeStart")]
public float CenterFadeStart { get; set;}

[REDProp("centerFadeRange")]
public float CenterFadeRange { get; set;}

[REDProp("colorGroupParamsIndex")]
public uint ColorGroupParamsIndex { get; set;}

[REDProp("alpha")]
public float Alpha { get; set;}

[REDProp("size")]
public float Size { get; set;}

[REDProp("aspect")]
public float Aspect { get; set;}

[REDProp("shift")]
public float Shift { get; set;}

[REDProp("pivot")]
public float Pivot { get; set;}

[REDProp("color")]
public Color Color { get; set;}

#endregion
}
}