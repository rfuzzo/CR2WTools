using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHasAbilityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("abilityName")]
public CName AbilityName { get; set;}

[REDProp("behVariableName")]
public CName BehVariableName { get; set;}

[REDProp("behVariableActivateValue")]
public float BehVariableActivateValue { get; set;}

[REDProp("behVariableDeactivateValue")]
public float BehVariableDeactivateValue { get; set;}

[REDProp("failAnim")]
public bool FailAnim { get; set;}

#endregion
}
}