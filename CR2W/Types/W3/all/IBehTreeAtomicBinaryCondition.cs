using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IBehTreeAtomicBinaryCondition : IBehTreeAtomicCondition
{
#region RED Properties

[REDProp("condition1")]
public Ptr<IBehTreeAtomicCondition> Condition1 { get; set;}

[REDProp("condition2")]
public Ptr<IBehTreeAtomicCondition> Condition2 { get; set;}

#endregion
}
}