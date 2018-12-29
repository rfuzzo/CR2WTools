using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTAdjustRotationChanges : IMoveSteeringTask
{
#region RED Properties

[REDProp("scenario")]
public EAdjustRotationChangesScenario Scenario { get; set;}

#endregion
}
}