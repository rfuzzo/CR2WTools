using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeAtomicNOTCondition : IBehTreeAtomicCondition
{
#region RED Properties

[REDProp("child")]
public Ptr<IBehTreeAtomicCondition> Child { get; set;}

#endregion
}
}