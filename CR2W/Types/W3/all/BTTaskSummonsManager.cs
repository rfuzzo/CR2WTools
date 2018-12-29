using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskSummonsManager : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("summonedEntities")]
public Array<Handle<CGameplayEntity>> SummonedEntities { get; set;}

[REDProp("summonedEntitiesSearchingRange")]
public float SummonedEntitiesSearchingRange { get; set;}

[REDProp("summonedEntitiesTag")]
public CName SummonedEntitiesTag { get; set;}

[REDProp("killEntitiesOnDistance")]
public bool KillEntitiesOnDistance { get; set;}

[REDProp("killDistance")]
public float KillDistance { get; set;}

#endregion
}
}