using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondTargetThreatLevelDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

#endregion
}
}