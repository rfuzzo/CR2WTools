using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCameraPivotPositionControllerExplorationInteraction : CCameraPivotPositionControllerJump
{
#region RED Properties

[REDProp("collisionOffsetF")]
public float CollisionOffsetF { get; set;}

[REDProp("explorationDirection")]
public Vector ExplorationDirection { get; set;}

[REDProp("collisionOffset")]
public Vector CollisionOffset { get; set;}

#endregion
}
}