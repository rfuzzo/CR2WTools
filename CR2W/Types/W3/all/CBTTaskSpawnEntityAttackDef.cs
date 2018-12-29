using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnEntityAttackDef : CBTTaskAttackDef
{
#region RED Properties

[REDProp("ressourceName")]
public CBehTreeValCName RessourceName { get; set;}

[REDProp("spawnAnimEventName")]
public CName SpawnAnimEventName { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("offsetVector")]
public Vector OffsetVector { get; set;}

[REDProp("completeAfterSpawn")]
public bool CompleteAfterSpawn { get; set;}

#endregion
}
}