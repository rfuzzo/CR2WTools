using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4LootDefinitionBase : CLootDefinitionBase
{
#region RED Properties

[REDProp("quantityMin")]
public uint QuantityMin { get; set;}

[REDProp("quantityMax")]
public uint QuantityMax { get; set;}

[REDProp("playerLevelMin")]
public uint PlayerLevelMin { get; set;}

[REDProp("playerLevelMax")]
public uint PlayerLevelMax { get; set;}

[REDProp("crafterLevelMin")]
public uint CrafterLevelMin { get; set;}

[REDProp("crafterLevelMax")]
public uint CrafterLevelMax { get; set;}

#endregion
}
}