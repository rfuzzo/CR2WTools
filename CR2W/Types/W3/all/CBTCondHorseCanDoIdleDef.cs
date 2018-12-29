using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondHorseCanDoIdleDef : IBehTreeHorseConditionalTaskDefinition
{
#region RED Properties

[REDProp("waitForMountEnd")]
public bool WaitForMountEnd { get; set;}

[REDProp("waitForDismountEnd")]
public bool WaitForDismountEnd { get; set;}

#endregion
}
}