using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NPCBackgroundPair : CGameplayEntity
{
#region RED Properties

[REDProp("work")]
public EBackgroundNPCWork_Paired Work { get; set;}

[REDProp("entitiesToSpawn")]
public Array<SBackgroundPairSpawnedEntity> EntitiesToSpawn { get; set;}

[REDProp("spawnedEntities")]
public Array<Handle<CEntity>> SpawnedEntities { get; set;}

[REDProp("currentAttachments")]
public Array<Handle<CEntity>> CurrentAttachments { get; set;}

[REDProp("slave")]
public Handle<W3NPCBackground> Slave { get; set;}

[REDProp("master")]
public Handle<W3NPCBackground> Master { get; set;}

[REDProp("mountEvents")]
public Array<SMountEvent> MountEvents { get; set;}

[REDProp("masterAC")]
public Handle<CAnimatedComponent> MasterAC { get; set;}

[REDProp("slaveAC")]
public Handle<CAnimatedComponent> SlaveAC { get; set;}

#endregion
}
}