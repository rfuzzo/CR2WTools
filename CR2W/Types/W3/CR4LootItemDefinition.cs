using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4LootItemDefinition : CR4LootDefinitionBase
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

[REDProp("name")]
public CName Name { get; set;}

[REDProp("chance")]
public float Chance { get; set;}

#endregion
}
}