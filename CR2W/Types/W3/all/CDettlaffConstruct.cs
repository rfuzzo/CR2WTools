using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDettlaffConstruct : CNewNPC
{
#region RED Properties

[REDProp("numberOfHits")]
public Int32 NumberOfHits { get; set;}

[REDProp("destroyCalled")]
public bool DestroyCalled { get; set;}

[REDProp("percLife")]
public float PercLife { get; set;}

[REDProp("chunkLife")]
public float ChunkLife { get; set;}

[REDProp("healthBarPerc")]
public float HealthBarPerc { get; set;}

[REDProp("lastHitTimestamp")]
public float LastHitTimestamp { get; set;}

[REDProp("testedHitTimestamp")]
public float TestedHitTimestamp { get; set;}

[REDProp("l_temp")]
public float L_temp { get; set;}

[REDProp("timeBetweenHits")]
public float TimeBetweenHits { get; set;}

[REDProp("timeBetweenFireDamage")]
public float TimeBetweenFireDamage { get; set;}

[REDProp("baseStat")]
public EBaseCharacterStats BaseStat { get; set;}

[REDProp("requiredHits")]
public Int32 RequiredHits { get; set;}

[REDProp("effectOnTakeDamage")]
public CName EffectOnTakeDamage { get; set;}

[REDProp("timeToDestroy")]
public float TimeToDestroy { get; set;}

#endregion
}
}