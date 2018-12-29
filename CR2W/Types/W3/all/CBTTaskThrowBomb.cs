using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskThrowBomb : CBTTaskAttack
{
#region RED Properties

[REDProp("thrownEntity")]
public Handle<W3Petard> ThrownEntity { get; set;}

[REDProp("inventory")]
public Handle<CInventoryComponent> Inventory { get; set;}

[REDProp("bombs")]
public Array<SItemUniqueId> Bombs { get; set;}

[REDProp("cachedTargetPos")]
public Vector CachedTargetPos { get; set;}

[REDProp("dontUseDiwmeritium")]
public bool DontUseDiwmeritium { get; set;}

[REDProp("activationChance")]
public float ActivationChance { get; set;}

#endregion
}
}