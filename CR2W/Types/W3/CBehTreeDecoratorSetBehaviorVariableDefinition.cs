using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeDecoratorSetBehaviorVariableDefinition : IBehTreeNodeDecoratorDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("VarName")]
public CName VarName { get; set;}

[REDProp("setVarActivate")]
public bool SetVarActivate { get; set;}

[REDProp("valueActivate")]
public float ValueActivate { get; set;}

[REDProp("setVarDeactivate")]
public bool SetVarDeactivate { get; set;}

[REDProp("valueDeactivate")]
public float ValueDeactivate { get; set;}

#endregion
}
}