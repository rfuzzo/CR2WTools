using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIStartingBehaviorParameters : CAIRedefinitionParameters
{
#region RED Properties

[REDProp("startingBehavior")]
public Handle<IAIActionTree> StartingBehavior { get; set;}

[REDProp("startingBehaviorPriority")]
public Int32 StartingBehaviorPriority { get; set;}

#endregion
}
}