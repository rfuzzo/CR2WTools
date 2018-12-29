using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ChooseGwintTurnPopup : ConfirmationPopupData
{
#region RED Properties

[REDProp("gwintMenuRef")]
public Handle<CR4GwintGameMenu> GwintMenuRef { get; set;}

#endregion
}
}