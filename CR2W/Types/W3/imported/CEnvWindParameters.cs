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
public class CEnvWindParameters 
{
#region RED Properties

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("windStrengthOverride")]
public SSimpleCurve WindStrengthOverride { get; set;}

[REDProp("cloudsVelocityOverride")]
public SSimpleCurve CloudsVelocityOverride { get; set;}

#endregion
}
}