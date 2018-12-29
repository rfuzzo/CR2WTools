using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIDynamicWanderParams : CAINpcWanderParams
{
#region RED Properties

[REDProp("dynamicWanderArea")]
public EntityHandle DynamicWanderArea { get; set;}

[REDProp("dynamicWanderIdleDuration")]
public float DynamicWanderIdleDuration { get; set;}

[REDProp("dynamicWanderIdleChance")]
public float DynamicWanderIdleChance { get; set;}

[REDProp("dynamicWanderMoveDuration")]
public float DynamicWanderMoveDuration { get; set;}

[REDProp("dynamicWanderMoveChance")]
public float DynamicWanderMoveChance { get; set;}

#endregion
}
}