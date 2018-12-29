using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondCheckStatValueDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("checkedActor")]
public EStatOwner CheckedActor { get; set;}

[REDProp("baseStatType")]
public EBaseCharacterStats BaseStatType { get; set;}

[REDProp("autoCheckHPType")]
public bool AutoCheckHPType { get; set;}

[REDProp("statValue")]
public float StatValue { get; set;}

[REDProp("percentage")]
public bool Percentage { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

#endregion
}
}