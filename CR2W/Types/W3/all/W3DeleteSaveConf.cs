using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DeleteSaveConf : ConfirmationPopupData
{
#region RED Properties

[REDProp("menuRef")]
public Handle<CR4IngameMenu> MenuRef { get; set;}

[REDProp("type")]
public ESaveGameType Type { get; set;}

[REDProp("slot")]
public Int32 Slot { get; set;}

[REDProp("saveMode")]
public bool SaveMode { get; set;}

#endregion
}
}