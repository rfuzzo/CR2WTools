using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskNPCNotInFrontOfPLayerDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("coneAngle")]
public float ConeAngle { get; set;}

[REDProp("angleOffset")]
public float AngleOffset { get; set;}

[REDProp("coneRange")]
public float ConeRange { get; set;}

#endregion
}
}