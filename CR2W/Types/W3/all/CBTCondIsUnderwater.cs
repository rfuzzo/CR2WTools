using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsUnderwater : IBehTreeTask
{
#region RED Properties

[REDProp("minSubmergeDepth")]
public float MinSubmergeDepth { get; set;}

#endregion
}
}