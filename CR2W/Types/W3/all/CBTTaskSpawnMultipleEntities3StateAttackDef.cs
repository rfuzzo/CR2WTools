using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnMultipleEntities3StateAttackDef : CBTTaskSpawnMultipleEntitiesAttackDef
{
#region RED Properties

[REDProp("delayActivationTime")]
public float DelayActivationTime { get; set;}

[REDProp("loopTime")]
public float LoopTime { get; set;}

[REDProp("spawnInterval")]
public float SpawnInterval { get; set;}

[REDProp("decreaseLoopTimePerFailedCreateEntity")]
public float DecreaseLoopTimePerFailedCreateEntity { get; set;}

[REDProp("spawnAdditionalEntityOnTargetPos")]
public bool SpawnAdditionalEntityOnTargetPos { get; set;}

#endregion
}
}