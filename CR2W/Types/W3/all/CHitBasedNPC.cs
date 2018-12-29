using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CHitBasedNPC : CNewNPC
{
#region RED Properties

[REDProp("hitsToDeath")]
public Int32 HitsToDeath { get; set;}

[REDProp("minTimeBetweenHits")]
public float MinTimeBetweenHits { get; set;}

[REDProp("baseStat")]
public EBaseCharacterStats BaseStat { get; set;}

[REDProp("chunkValue")]
public float ChunkValue { get; set;}

[REDProp("hitsTaken")]
public Int32 HitsTaken { get; set;}

[REDProp("lastHitTimestamp")]
public float LastHitTimestamp { get; set;}

[REDProp("wasInitialized")]
public bool WasInitialized { get; set;}

#endregion
}
}