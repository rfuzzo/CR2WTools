using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CCharacterControllerParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("height")]
public float Height { get; set;}

[REDProp("physicalRadius")]
public float PhysicalRadius { get; set;}

[REDProp("baseVirtualCharacterRadius")]
public float BaseVirtualCharacterRadius { get; set;}

[REDProp("customAvoidanceRadius")]
public float CustomAvoidanceRadius { get; set;}

[REDProp("interactionPriority")]
public float InteractionPriority { get; set;}

[REDProp("interactionPriorityEnum")]
public EInteractionPriority InteractionPriorityEnum { get; set;}

[REDProp("stepOffset")]
public float StepOffset { get; set;}

[REDProp("collisionType")]
public CPhysicalCollision CollisionType { get; set;}

[REDProp("collisionPrediction")]
public bool CollisionPrediction { get; set;}

[REDProp("collisionPredictionMovementAdd")]
public float CollisionPredictionMovementAdd { get; set;}

[REDProp("collisionPredictionMovementMul")]
public float CollisionPredictionMovementMul { get; set;}

[REDProp("collisionPredictionEventName")]
public CName CollisionPredictionEventName { get; set;}

[REDProp("radiuses")]
public Array<SControllerRadiusParams> Radiuses { get; set;}

[REDProp("virtualControllers")]
public Array<SVirtualControllerParams> VirtualControllers { get; set;}

[REDProp("customMovableRep")]
public Ptr<CMovableRepresentationCreator> CustomMovableRep { get; set;}

[REDProp("significance")]
public float Significance { get; set;}

#endregion
}
}