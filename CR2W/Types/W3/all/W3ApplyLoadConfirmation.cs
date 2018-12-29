using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ApplyLoadConfirmation : ConfirmationPopupData
{
#region RED Properties

[REDProp("menuRef")]
public Handle<CR4IngameMenu> MenuRef { get; set;}

[REDProp("saveSlotRef")]
public SSavegameInfo SaveSlotRef { get; set;}

[REDProp("accepted")]
public bool Accepted { get; set;}

#endregion
}
}