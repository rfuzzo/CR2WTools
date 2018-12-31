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
public class CEnvReflectionProbesGenParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("colorAmbient")]
public SSimpleCurve ColorAmbient { get; set;}

[REDProp("colorSceneMul")]
public SSimpleCurve ColorSceneMul { get; set;}

[REDProp("colorSceneAdd")]
public SSimpleCurve ColorSceneAdd { get; set;}

[REDProp("colorSkyMul")]
public SSimpleCurve ColorSkyMul { get; set;}

[REDProp("colorSkyAdd")]
public SSimpleCurve ColorSkyAdd { get; set;}

[REDProp("remapOffset")]
public SSimpleCurve RemapOffset { get; set;}

[REDProp("remapStrength")]
public SSimpleCurve RemapStrength { get; set;}

[REDProp("remapClamp")]
public SSimpleCurve RemapClamp { get; set;}

#endregion
}
}