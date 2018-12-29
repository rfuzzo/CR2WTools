using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class PriceConfirmationPopupData : ConfirmationPopupData
{
#region RED Properties

[REDProp("m_Price")]
public float M_Price { get; set;}

[REDProp("itemId")]
public SItemUniqueId ItemId { get; set;}

[REDProp("isStandaloneDismantle")]
public bool IsStandaloneDismantle { get; set;}

[REDProp("menuRef")]
public Handle<CR4BlacksmithMenu> MenuRef { get; set;}

#endregion
}
}