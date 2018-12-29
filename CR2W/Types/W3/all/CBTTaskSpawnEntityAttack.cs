using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnEntityAttack : CBTTaskAttack
{
#region RED Properties

[REDProp("offsetVector")]
public Vector OffsetVector { get; set;}

[REDProp("ressourceName")]
public CName RessourceName { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("spawnAnimEventName")]
public CName SpawnAnimEventName { get; set;}

[REDProp("completeAfterSpawn")]
public bool CompleteAfterSpawn { get; set;}

[REDProp("m_summonerComponent")]
public Handle<W3SummonerComponent> M_summonerComponent { get; set;}

[REDProp("couldntLoadResource")]
public bool CouldntLoadResource { get; set;}

#endregion
}
}