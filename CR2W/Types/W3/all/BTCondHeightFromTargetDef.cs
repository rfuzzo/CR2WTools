using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondHeightFromTargetDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("value")]
public float Value { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

#endregion
}
}