using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMultiTransitionCondition : IBehaviorStateTransitionCondition
{
#region RED Properties

[REDProp("conditions")]
public Array<Ptr<IBehaviorStateTransitionCondition>> Conditions { get; set;}

#endregion
}
}