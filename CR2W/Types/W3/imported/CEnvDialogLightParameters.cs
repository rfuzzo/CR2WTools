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
public class CEnvDialogLightParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("lightColor")]
public SSimpleCurve LightColor { get; set;}

[REDProp("lightColor2")]
public SSimpleCurve LightColor2 { get; set;}

[REDProp("lightColor3")]
public SSimpleCurve LightColor3 { get; set;}

#endregion
}
}