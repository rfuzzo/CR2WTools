using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageObjectsInPhantomComponentSlotsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("checkDistanceOnIsAvailable")]
public bool CheckDistanceOnIsAvailable { get; set;}

[REDProp("createEntityResourceNames")]
public Array<CName> CreateEntityResourceNames { get; set;}

[REDProp("attachSlotNames")]
public Array<CName> AttachSlotNames { get; set;}

[REDProp("activateOnAnimEvent")]
public CName ActivateOnAnimEvent { get; set;}

[REDProp("drawEntitiesFromArea")]
public bool DrawEntitiesFromArea { get; set;}

[REDProp("snapDrawnEntityToGround")]
public bool SnapDrawnEntityToGround { get; set;}

[REDProp("shootAtLookatTarget")]
public bool ShootAtLookatTarget { get; set;}

[REDProp("shootAllDrawnEntitiesAtOnce")]
public bool ShootAllDrawnEntitiesAtOnce { get; set;}

[REDProp("drawEntitiesRadius")]
public float DrawEntitiesRadius { get; set;}

[REDProp("drawEntitiesTag")]
public CName DrawEntitiesTag { get; set;}

[REDProp("drawSpeedLimit")]
public float DrawSpeedLimit { get; set;}

[REDProp("destroyEntityOnAnimEvent")]
public CName DestroyEntityOnAnimEvent { get; set;}

[REDProp("shootEntityOnAnimEvent")]
public CName ShootEntityOnAnimEvent { get; set;}

[REDProp("disperseObjectsOnAnimEvent")]
public CName DisperseObjectsOnAnimEvent { get; set;}

[REDProp("playEffectOnEntityPull")]
public CName PlayEffectOnEntityPull { get; set;}

[REDProp("playEffectOnEntityAttach")]
public CName PlayEffectOnEntityAttach { get; set;}

[REDProp("playEffectOnDestroyEntity")]
public CName PlayEffectOnDestroyEntity { get; set;}

[REDProp("playEffectOnDisperseObjects")]
public CName PlayEffectOnDisperseObjects { get; set;}

#endregion
}
}