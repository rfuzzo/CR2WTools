using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DragonsDream : W3Petard
{
#region RED Properties

[REDProp("gasEntityTemplate")]
public Handle<CEntityTemplate> GasEntityTemplate { get; set;}

[REDProp("gasEntity")]
public Handle<W3ToxicCloud> GasEntity { get; set;}

[REDProp("burningChance")]
public float BurningChance { get; set;}

#endregion
}
}