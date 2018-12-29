using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageFlies : IBehTreeTask
{
#region RED Properties

[REDProp("entityToSummon")]
public Handle<CEntityTemplate> EntityToSummon { get; set;}

[REDProp("maxFliesAlive")]
public Int32 MaxFliesAlive { get; set;}

[REDProp("delayBetweenSpawns")]
public SRangeF DelayBetweenSpawns { get; set;}

[REDProp("delayToRespawn")]
public SRangeF DelayToRespawn { get; set;}

[REDProp("m_summonerCmp")]
public Handle<W3SummonerComponent> M_summonerCmp { get; set;}

[REDProp("m_DelayToNextSpawn")]
public float M_DelayToNextSpawn { get; set;}

#endregion
}
}