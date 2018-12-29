using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHangingFromCeilingSpawn : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("availableOnBehVarName")]
public CName AvailableOnBehVarName { get; set;}

[REDProp("availableOnBehVarValue")]
public float AvailableOnBehVarValue { get; set;}

[REDProp("spawnOnHit")]
public bool SpawnOnHit { get; set;}

[REDProp("spawnOnDistanceToHostile")]
public float SpawnOnDistanceToHostile { get; set;}

[REDProp("spawnOnGameplayEventName")]
public CName SpawnOnGameplayEventName { get; set;}

[REDProp("spawnOnAnimEventName")]
public CName SpawnOnAnimEventName { get; set;}

[REDProp("traceToCeiling")]
public bool TraceToCeiling { get; set;}

[REDProp("verticalAdjustment")]
public bool VerticalAdjustment { get; set;}

[REDProp("horizontalAdjustment")]
public bool HorizontalAdjustment { get; set;}

[REDProp("manageGravity")]
public bool ManageGravity { get; set;}

[REDProp("manageCollision")]
public bool ManageCollision { get; set;}

[REDProp("reenableCollisionAfter")]
public float ReenableCollisionAfter { get; set;}

[REDProp("setCustomMovement")]
public bool SetCustomMovement { get; set;}

[REDProp("raiseEvent")]
public CName RaiseEvent { get; set;}

[REDProp("timeOfInitialPosCorrection")]
public float TimeOfInitialPosCorrection { get; set;}

[REDProp("reuseInitialSpawnPosition")]
public bool ReuseInitialSpawnPosition { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("raisedEvent")]
public bool RaisedEvent { get; set;}

[REDProp("slideEventReceived")]
public bool SlideEventReceived { get; set;}

[REDProp("actorPos")]
public Vector ActorPos { get; set;}

[REDProp("initialPos")]
public Vector InitialPos { get; set;}

[REDProp("animInfoCache")]
public SAnimationEventAnimInfo AnimInfoCache { get; set;}

[REDProp("collisionGroups")]
public Array<CName> CollisionGroups { get; set;}

#endregion
}
}