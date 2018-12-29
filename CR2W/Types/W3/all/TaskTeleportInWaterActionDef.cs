using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TaskTeleportInWaterActionDef : TaskTeleportActionDef
{
#region RED Properties

[REDProp("waterDepthNeeded")]
public float WaterDepthNeeded { get; set;}

#endregion
}
}