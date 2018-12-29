using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDettlaffColumn : CNewNPC
{
#region RED Properties

[REDProp("numberOfHits")]
public Int32 NumberOfHits { get; set;}

[REDProp("destroyCalled")]
public bool DestroyCalled { get; set;}

[REDProp("foundEntity")]
public Handle<CEntity> FoundEntity { get; set;}

[REDProp("construct")]
public Handle<CActor> Construct { get; set;}

[REDProp("summonedComp")]
public Handle<W3SummonedEntityComponent> SummonedComp { get; set;}

[REDProp("percLife")]
public float PercLife { get; set;}

[REDProp("chunkLife")]
public float ChunkLife { get; set;}

[REDProp("lastHitTimestamp")]
public float LastHitTimestamp { get; set;}

[REDProp("testedHitTimestamp")]
public float TestedHitTimestamp { get; set;}

[REDProp("requiredHits")]
public Int32 RequiredHits { get; set;}

[REDProp("timeBetweenHits")]
public float TimeBetweenHits { get; set;}

[REDProp("timeBetweenFireDamage")]
public float TimeBetweenFireDamage { get; set;}

[REDProp("effectOnTakeDamage")]
public CName EffectOnTakeDamage { get; set;}

[REDProp("timeToDestroy")]
public float TimeToDestroy { get; set;}

#endregion
}
}