using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Oil : CBaseGameplayEffect
{
#region RED Properties

[REDProp("currCount")]
public Int32 CurrCount { get; set;}

[REDProp("maxCount")]
public Int32 MaxCount { get; set;}

[REDProp("sword")]
public SItemUniqueId Sword { get; set;}

[REDProp("oilAbility")]
public CName OilAbility { get; set;}

[REDProp("oilItemName")]
public CName OilItemName { get; set;}

[REDProp("queueTimer")]
public Int32 QueueTimer { get; set;}

#endregion
}
}