using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GuiDisassembleInventoryComponent : W3GuiPlayerInventoryComponent
{
#region RED Properties

[REDProp("merchantInv")]
public Handle<CInventoryComponent> MerchantInv { get; set;}

#endregion
}
}