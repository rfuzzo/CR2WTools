using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeAtomicORCondition : IBehTreeAtomicBinaryCondition
{
#region RED Properties

[REDProp("condition1")]
public Ptr<IBehTreeAtomicCondition> Condition1 { get; set;}

[REDProp("condition2")]
public Ptr<IBehTreeAtomicCondition> Condition2 { get; set;}

#endregion
}
}