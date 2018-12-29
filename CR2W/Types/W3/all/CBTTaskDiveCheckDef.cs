using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDiveCheckDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("frontOffset")]
public float FrontOffset { get; set;}

[REDProp("minWaterDepth")]
public float MinWaterDepth { get; set;}

[REDProp("maxWaterDistance")]
public float MaxWaterDistance { get; set;}

#endregion
}
}