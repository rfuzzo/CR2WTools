using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SLensFlareParameters 
{
#region RED Properties

[REDProp("nearDistance")]
public float NearDistance { get; set;}

[REDProp("nearRange")]
public float NearRange { get; set;}

[REDProp("farDistance")]
public float FarDistance { get; set;}

[REDProp("farRange")]
public float FarRange { get; set;}

[REDProp("elements")]
public Array<SLensFlareElementParameters> Elements { get; set;}

#endregion
}
}