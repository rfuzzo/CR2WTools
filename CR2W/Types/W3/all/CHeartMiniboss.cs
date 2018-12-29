using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHeartMiniboss : CNewNPC
{
#region RED Properties

[REDProp("phasesCount")]
public Int32 PhasesCount { get; set;}

[REDProp("currentPhase")]
public Int32 CurrentPhase { get; set;}

[REDProp("essenceChunks")]
public Int32 EssenceChunks { get; set;}

[REDProp("essenceChunkValue")]
public float EssenceChunkValue { get; set;}

[REDProp("canHit")]
public bool CanHit { get; set;}

[REDProp("valuesInitialised")]
public bool ValuesInitialised { get; set;}

[REDProp("factSetAfterDeath")]
public string FactSetAfterDeath { get; set;}

[REDProp("factSetInOpenedPhase")]
public string FactSetInOpenedPhase { get; set;}

[REDProp("factSetInArmoredPhase")]
public string FactSetInArmoredPhase { get; set;}

#endregion
}
}