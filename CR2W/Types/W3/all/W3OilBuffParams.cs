using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3OilBuffParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("iconPath")]
public string IconPath { get; set;}

[REDProp("localizedName")]
public string LocalizedName { get; set;}

[REDProp("localizedDescription")]
public string LocalizedDescription { get; set;}

[REDProp("currCount")]
public Int32 CurrCount { get; set;}

[REDProp("maxCount")]
public Int32 MaxCount { get; set;}

[REDProp("sword")]
public SItemUniqueId Sword { get; set;}

[REDProp("oilAbilityName")]
public CName OilAbilityName { get; set;}

[REDProp("oilItemName")]
public CName OilItemName { get; set;}

#endregion
}
}