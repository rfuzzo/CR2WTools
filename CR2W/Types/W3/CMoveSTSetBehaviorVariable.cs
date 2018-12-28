using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTSetBehaviorVariable : IMoveSteeringTask
{
#region RED Properties

[REDProp("variableContext")]
public EBehaviorVarContext VariableContext { get; set;}

[REDProp("variableName")]
public CName VariableName { get; set;}

[REDProp("value")]
public float Value { get; set;}

#endregion
}
}