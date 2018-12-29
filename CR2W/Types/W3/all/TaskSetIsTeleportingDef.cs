using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskSetIsTeleportingDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("SetToFalseOnDeactivate")]
public bool SetToFalseOnDeactivate { get; set;}

#endregion
}
}