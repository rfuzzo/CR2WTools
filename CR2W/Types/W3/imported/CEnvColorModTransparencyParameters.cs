using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvColorModTransparencyParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("commonFarDist")]
public SSimpleCurve CommonFarDist { get; set;}

[REDProp("filterNearColor")]
public SSimpleCurve FilterNearColor { get; set;}

[REDProp("filterFarColor")]
public SSimpleCurve FilterFarColor { get; set;}

[REDProp("contrastNearStrength")]
public SSimpleCurve ContrastNearStrength { get; set;}

[REDProp("contrastFarStrength")]
public SSimpleCurve ContrastFarStrength { get; set;}

[REDProp("autoHideCustom0")]
public CEnvDistanceRangeParameters AutoHideCustom0 { get; set;}

[REDProp("autoHideCustom1")]
public CEnvDistanceRangeParameters AutoHideCustom1 { get; set;}

[REDProp("autoHideCustom2")]
public CEnvDistanceRangeParameters AutoHideCustom2 { get; set;}

[REDProp("autoHideCustom3")]
public CEnvDistanceRangeParameters AutoHideCustom3 { get; set;}

#endregion
}
}