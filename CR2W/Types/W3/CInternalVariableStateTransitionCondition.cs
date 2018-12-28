using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CInternalVariableStateTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("variableName")]
public CName VariableName { get; set;}

[REDProp("compareValue")]
public float CompareValue { get; set;}

[REDProp("compareFunc")]
public ECompareFunc CompareFunc { get; set;}

#endregion
}
}