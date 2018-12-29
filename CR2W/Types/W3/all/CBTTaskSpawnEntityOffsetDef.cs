using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnEntityOffsetDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("resourceName")]
public CBehTreeValCName ResourceName { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("positionOffset")]
public Vector PositionOffset { get; set;}

[REDProp("completeAfterSpawn")]
public bool CompleteAfterSpawn { get; set;}

[REDProp("complete")]
public bool Complete { get; set;}

[REDProp("spawnEntityOnAnimEvent")]
public bool SpawnEntityOnAnimEvent { get; set;}

[REDProp("spawnAnimEventName")]
public CName SpawnAnimEventName { get; set;}

[REDProp("addEntityToSummonerComponent")]
public bool AddEntityToSummonerComponent { get; set;}

[REDProp("addTagToEntity")]
public bool AddTagToEntity { get; set;}

[REDProp("tagToAdd")]
public CName TagToAdd { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("destroyTaggedEntitiesOnDeactivate")]
public bool DestroyTaggedEntitiesOnDeactivate { get; set;}

[REDProp("destroyEntityAfter")]
public float DestroyEntityAfter { get; set;}

[REDProp("entity")]
public Handle<CEntity> Entity { get; set;}

[REDProp("entities")]
public Array<Handle<CEntity>> Entities { get; set;}

[REDProp("spawnEntityAtNode")]
public bool SpawnEntityAtNode { get; set;}

[REDProp("tagToFindNode")]
public CName TagToFindNode { get; set;}

#endregion
}
}