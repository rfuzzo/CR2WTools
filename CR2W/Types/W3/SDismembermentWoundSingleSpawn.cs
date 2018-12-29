using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SDismembermentWoundSingleSpawn 
{
#region RED Properties

[REDProp("spawnedEntity")]
public Handle<CEntityTemplate> SpawnedEntity { get; set;}

[REDProp("spawnEntityBoneName")]
public CName SpawnEntityBoneName { get; set;}

[REDProp("spawnedEntityCurveName")]
public CName SpawnedEntityCurveName { get; set;}

[REDProp("droppedEquipmentTag")]
public CName DroppedEquipmentTag { get; set;}

[REDProp("soundEvents")]
public Array<StringAnsi> SoundEvents { get; set;}

[REDProp("despawnAlongWithBase")]
public bool DespawnAlongWithBase { get; set;}

[REDProp("syncPose")]
public bool SyncPose { get; set;}

[REDProp("fixBaseBonesHierarchyType")]
public EFixBonesHierarchyType FixBaseBonesHierarchyType { get; set;}

[REDProp("fixSpawnedBonesHierarchyType")]
public EFixBonesHierarchyType FixSpawnedBonesHierarchyType { get; set;}

[REDProp("effectsNames")]
public Array<CName> EffectsNames { get; set;}

[REDProp("additionalEffects")]
public Array<SDismembermentEffect> AdditionalEffects { get; set;}

#endregion
}
}