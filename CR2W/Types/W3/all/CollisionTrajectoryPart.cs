using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CollisionTrajectoryPart : CPhantomComponent
{
#region RED Properties

[REDProp("triggeredCollisions")]
public Int32 TriggeredCollisions { get; set;}

[REDProp("waterCollisions")]
public Int32 WaterCollisions { get; set;}

[REDProp("ownerTrajectory")]
public Handle<CollisionTrajectory> OwnerTrajectory { get; set;}

[REDProp("part")]
public ECollisionTrajectoryPart Part { get; set;}

[REDProp("waterUpPosCheckSlotName")]
public CName WaterUpPosCheckSlotName { get; set;}

[REDProp("waterDownPosCheckSlotName")]
public CName WaterDownPosCheckSlotName { get; set;}

#endregion
}
}