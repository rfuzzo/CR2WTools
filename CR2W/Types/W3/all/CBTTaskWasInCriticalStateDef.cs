using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskWasInCriticalStateDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("maxTimeDifference")]
public float MaxTimeDifference { get; set;}

[REDProp("criticalState")]
public ECriticalStateType CriticalState { get; set;}

#endregion
}
}