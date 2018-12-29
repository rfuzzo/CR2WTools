using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_AutoStaminaRegen : W3AutoRegenEffect
{
#region RED Properties

[REDProp("regenModeIsCombat")]
public bool RegenModeIsCombat { get; set;}

[REDProp("cachedPlayer")]
public Handle<CR4Player> CachedPlayer { get; set;}

#endregion
}
}