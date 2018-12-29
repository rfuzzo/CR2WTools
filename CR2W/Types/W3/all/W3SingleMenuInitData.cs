using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SingleMenuInitData : W3MenuInitData
{
#region RED Properties

[REDProp("fixedMenuName")]
public CName FixedMenuName { get; set;}

[REDProp("ignoreMeditationCheck")]
public bool IgnoreMeditationCheck { get; set;}

[REDProp("isBonusMeditationAvailable")]
public bool IsBonusMeditationAvailable { get; set;}

[REDProp("unlockCraftingMenu")]
public bool UnlockCraftingMenu { get; set;}

[REDProp("m_blockOtherPanels")]
public bool M_blockOtherPanels { get; set;}

#endregion
}
}