using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskManageFliesDef : IBehTreeTaskDefinition
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

#endregion
}
}