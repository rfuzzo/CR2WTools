using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3GwintQuitConfPopup : ConfirmationPopupData
{
#region RED Properties

[REDProp("gwintMenuRef")]
public Handle<CR4GwintBaseMenu> GwintMenuRef { get; set;}

#endregion
}
}