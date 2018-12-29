using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondWaterDepthDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("checkedActor")]
public EStatOwner CheckedActor { get; set;}

[REDProp("value")]
public float Value { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("frontalOffset")]
public float FrontalOffset { get; set;}

#endregion
}
}