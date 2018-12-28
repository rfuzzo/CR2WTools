using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphBlendMultipleCondNode_ConstDampMethod : IBehaviorGraphBlendMultipleCondNode_DampMethod
{
#region RED Properties

[REDProp("speed")]
public float Speed { get; set;}

#endregion
}
}