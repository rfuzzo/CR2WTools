using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageObjectsInPhantomComponentSlots : IBehTreeTask
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

[REDProp("drawEntitiesRadius")]
public float DrawEntitiesRadius { get; set;}

[REDProp("drawEntitiesTag")]
public CName DrawEntitiesTag { get; set;}

[REDProp("drawSpeedLimit")]
public float DrawSpeedLimit { get; set;}

[REDProp("snapDrawnEntityToGround")]
public bool SnapDrawnEntityToGround { get; set;}

[REDProp("shootAtLookatTarget")]
public bool ShootAtLookatTarget { get; set;}

[REDProp("destroyEntityOnAnimEvent")]
public CName DestroyEntityOnAnimEvent { get; set;}

[REDProp("shootEntityOnAnimEvent")]
public CName ShootEntityOnAnimEvent { get; set;}

[REDProp("shootAllDrawnEntitiesAtOnce")]
public bool ShootAllDrawnEntitiesAtOnce { get; set;}

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

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_CreateEntityTemplates")]
public Array<Handle<CEntityTemplate>> M_CreateEntityTemplates { get; set;}

[REDProp("m_EntitiesDrawnFromArea")]
public Array<Handle<CEntity>> M_EntitiesDrawnFromArea { get; set;}

[REDProp("m_CurveComponents")]
public Array<Handle<CComponent>> M_CurveComponents { get; set;}

[REDProp("m_activateEventReceived")]
public bool M_activateEventReceived { get; set;}

[REDProp("m_destroyEntityEventReceived")]
public bool M_destroyEntityEventReceived { get; set;}

[REDProp("m_disperceObjectsEventReceived")]
public bool M_disperceObjectsEventReceived { get; set;}

[REDProp("m_shootEntityEventReceived")]
public bool M_shootEntityEventReceived { get; set;}

[REDProp("m_entityResourceNameFilled")]
public bool M_entityResourceNameFilled { get; set;}

[REDProp("m_prevDesiredAffectedEntityPos")]
public Vector M_prevDesiredAffectedEntityPos { get; set;}

[REDProp("m_prevSpeed")]
public float M_prevSpeed { get; set;}

[REDProp("m_ClosestSlot")]
public CName M_ClosestSlot { get; set;}

[REDProp("m_attachEntitiesArray")]
public Array<Handle<CEntity>> M_attachEntitiesArray { get; set;}

[REDProp("m_collisionGroups")]
public Array<CName> M_collisionGroups { get; set;}

[REDProp("m_drawnEntities")]
public Int32 M_drawnEntities { get; set;}

[REDProp("m_checkedForEntities")]
public bool M_checkedForEntities { get; set;}

#endregion
}
}