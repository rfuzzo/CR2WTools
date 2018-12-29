using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CPopsGasEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("restorationTime")]
public float RestorationTime { get; set;}

[REDProp("settlingTime")]
public float SettlingTime { get; set;}

[REDProp("fxOnSpawn")]
public CName FxOnSpawn { get; set;}

[REDProp("immunityFact")]
public string ImmunityFact { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("settled")]
public bool Settled { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("victims")]
public Array<Handle<CActor>> Victims { get; set;}

[REDProp("poisonArea")]
public Handle<CTriggerAreaComponent> PoisonArea { get; set;}

[REDProp("buffParams")]
public SCustomEffectParams BuffParams { get; set;}

#endregion
}
}