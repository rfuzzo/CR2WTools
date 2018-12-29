using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GameLog : CObject
{
#region RED Properties

[REDProp("COLOR_GOLD_BEGIN")]
public string COLOR_GOLD_BEGIN { get; set;}

[REDProp("COLOR_GOLD_END")]
public string COLOR_GOLD_END { get; set;}

[REDProp("cachedCombatMessages")]
public Array<SCachedCombatMessage> CachedCombatMessages { get; set;}

#endregion
}
}