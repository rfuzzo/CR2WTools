using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleDamagedItems : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxSetItemDamaged")]
public Handle<CScriptedFlashFunction> M_fxSetItemDamaged { get; set;}

[REDProp("damagedItems")]
public Array<bool> DamagedItems { get; set;}

[REDProp("inv")]
public Handle<CInventoryComponent> Inv { get; set;}

[REDProp("isDisplayed")]
public bool IsDisplayed { get; set;}

#endregion
}
}