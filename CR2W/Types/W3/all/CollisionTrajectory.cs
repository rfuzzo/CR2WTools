using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CollisionTrajectory : CGameplayEntity
{
#region RED Properties

[REDProp("stateManager")]
public Handle<CExplorationStateManager> StateManager { get; set;}

[REDProp("collisionSegmentsArr")]
public Array<Handle<CollisionTrajectoryPart>> CollisionSegmentsArr { get; set;}

[REDProp("firstSegmentCollision")]
public ECollisionTrajectoryPart FirstSegmentCollision { get; set;}

[REDProp("trajectoryStatusLastChecked")]
public ECollisionTrajecoryStatus TrajectoryStatusLastChecked { get; set;}

[REDProp("trajecoryExpStatusLastChecked")]
public ECollisionTrajecoryExplorationStatus TrajecoryExpStatusLastChecked { get; set;}

[REDProp("goingToWaterLastState")]
public ECollisionTrajectoryToWaterState GoingToWaterLastState { get; set;}

[REDProp("computedCollisionState")]
public bool ComputedCollisionState { get; set;}

[REDProp("computedGoingToWater")]
public bool ComputedGoingToWater { get; set;}

#endregion
}
}