using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvAmbientProbesGenParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("colorAmbient")]
public SSimpleCurve ColorAmbient { get; set;}

[REDProp("colorSceneAdd")]
public SSimpleCurve ColorSceneAdd { get; set;}

[REDProp("colorSkyTop")]
public SSimpleCurve ColorSkyTop { get; set;}

[REDProp("colorSkyHorizon")]
public SSimpleCurve ColorSkyHorizon { get; set;}

[REDProp("skyShape")]
public SSimpleCurve SkyShape { get; set;}

#endregion
}
}