using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActionConfirmation : ConfirmationPopupData
{
#region RED Properties

[REDProp("menuRef")]
public Handle<CR4IngameMenu> MenuRef { get; set;}

[REDProp("actionID")]
public Int32 ActionID { get; set;}

#endregion
}
}