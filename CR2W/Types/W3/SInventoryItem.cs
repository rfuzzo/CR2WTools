using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SInventoryItem 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("itemQuantity")]
public uint ItemQuantity { get; set;}

[REDProp("uniqueId")]
public SItemUniqueId UniqueId { get; set;}

[REDProp("flags")]
public UInt64 Flags { get; set;}

[REDProp("staticRandomSeed")]
public UInt16 StaticRandomSeed { get; set;}

[REDProp("uiData")]
public SInventoryItemUIData UiData { get; set;}

[REDProp("craftedAbilities")]
public Array<CName> CraftedAbilities { get; set;}

[REDProp("enchantmentName")]
public CName EnchantmentName { get; set;}

[REDProp("enchantmentStats")]
public CName EnchantmentStats { get; set;}

[REDProp("dyeColorName")]
public CName DyeColorName { get; set;}

[REDProp("dyeColorAbilityName")]
public CName DyeColorAbilityName { get; set;}

[REDProp("dyePreviewColorName")]
public CName DyePreviewColorName { get; set;}

#endregion
}
}